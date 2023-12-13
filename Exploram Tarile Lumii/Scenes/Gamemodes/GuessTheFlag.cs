using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exploram_Tarile_Lumii.Scenes.Gamemodes
{
    public partial class GuessTheFlag : UserControl
    {
        private Country country;
        private Random random;

        private List<int> usedCountryIndexes;
        private List<Button> choiceButtons;

        private int correct_answers;

        public GuessTheFlag()
        {
            InitializeComponent();
            random = new Random();
            usedCountryIndexes = new List<int>();
            choiceButtons = new List<Button>
            {
                BTN_Choice1,
                BTN_Choice2,
                BTN_Choice3
            };
        }

        private void Close()
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void AssignToRandomButton()
        {
            int selection = random.Next(0, choiceButtons.Count);
            int generation;
            // Assign first the randomly selected button to prevent buttons with the same name.
            // It happens if the selection is on the 2nd or 3rd and there is a chance to generate
            // the first same as the correct answer. - (Debugged by Petru)
            choiceButtons[selection].Text = country.name;
            for (int i = 0; i < 3; i++)
            {
                if (selection == i)
                { continue; }
                do
                {
                    generation = random.Next(0, Main_Form.countryList.Count);
                } while (choiceButtons.Any(button => button.Text == Main_Form.countryList[generation].name));
                choiceButtons[i].Text = Main_Form.countryList[generation].name;
            }
        }

        private void ChooseRandomCountry()
        {
            if (usedCountryIndexes.Count == Main_Form.countryList.Count)
            {
                MessageBox.Show($"Congrats, you guessed: {correct_answers}/{Main_Form.countryList.Count}", "Game Over");
                this.Close();
                return;
            }

            int generation;
            do
            {
                generation = random.Next(0, Main_Form.countryList.Count);
            } while (usedCountryIndexes.Any(item => item == generation) == true);
            usedCountryIndexes.Add(generation);
            country = Main_Form.countryList[generation];
            pictureBox_Flag.BackgroundImage = country.flag;
            AssignToRandomButton();
        }

        private void Setup(object sender, EventArgs e)
        {
            correct_answers = 0;
            ChooseRandomCountry();
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            foreach (var button in choiceButtons)
            {
                if (sender.GetHashCode() == button.GetHashCode() && button.Text == country.name)
                {
                    // Corect answer.
                    correct_answers++;
                    ChooseRandomCountry();
                    return;
                }
            }

            // Incorrect answer.
            ChooseRandomCountry();
        }
    }
}
