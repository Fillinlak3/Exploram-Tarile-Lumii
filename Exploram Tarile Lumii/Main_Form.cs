using static System.Windows.Forms.Design.AxImporter;
using System.Text.Json;
using System.Diagnostics;
using System.Reflection;
using Exploram_Tarile_Lumii.Properties;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Linq;

namespace Exploram_Tarile_Lumii
{
    public partial class Main_Form : Form
    {
        public static List<Country>? countryList;
        private string? resourcesPath;

        public Main_Form()
        {
            InitializeComponent();

            countryList = new List<Country>();
            HideAllViews();
            GetResourcesPath();
        }

        private async void Main_Form_Load(object sender, EventArgs e)
        {
            countryList = ParseJson(File.ReadAllText(@$"{resourcesPath}countries.json"));
            // Center UI Controls.
            Scene_MainMenu.Location = new Point((this.Width - Scene_MainMenu.Width) / 2, (this.Height - Scene_MainMenu.Height) / 2);
            Scene_SelectGamemode.Location = new Point((this.Width - Scene_SelectGamemode.Width) / 2, (this.Height - Scene_SelectGamemode.Height) / 2);
            Debug.WriteLine($"MM: {Scene_MainMenu.Location} - GM: {Scene_SelectGamemode.Location}");
            // Load the Main Menu Scene.
            Scene_MainMenu.Visible = true;
            // Wait for the form to load.
            await Task.Delay(1000);
            // Debug the json.
            await PrintAllJsonContent();
        }

        private void GetResourcesPath()
        {
            string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            // Combine the current directory with ".." to go up one level
            string parentDirectory = Path.Combine(currentDirectory, "..");
            parentDirectory = Path.Combine(parentDirectory, "..");
            parentDirectory = Path.Combine(parentDirectory, "..");
            // Get the full path of the parent directory
            resourcesPath = Path.GetFullPath(parentDirectory) + @"\resources\";
        }

        private List<Country> ParseJson(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) return new List<Country>();

            var array = JsonSerializer.Deserialize<List<Dictionary<string, Dictionary<string, object>>>>(json);

            var countries = array!.SelectMany(dict =>
            {
                return dict.Select(entry =>
                {
                    var index = int.Parse(entry.Key);
                    var countryDetails = entry.Value;

                    var currencyJsonElement = (JsonElement)countryDetails["currency"];
                    var currencyDict = JsonSerializer.Deserialize<Dictionary<string, object>>(currencyJsonElement.GetRawText());

                    #pragma warning disable 8601, 8602
                    return new Country
                    {
                        id = index,
                        name = countryDetails["name"].ToString(),
                        capital = countryDetails["capital"].ToString(),
                        region = countryDetails["region"].ToString(),
                        currency = new Country.Currency
                        {
                            name = currencyDict["name"].ToString(),
                            code = currencyDict["code"].ToString(),
                            symbol = currencyDict["symbol"].ToString()
                        },
                        language = countryDetails["language"].ToString(),
                        flag = new Bitmap(@$"{resourcesPath}flags\{countryDetails["flag"]}"),
                        area = countryDetails["area"].ToString(),
                        density = countryDetails["density"].ToString(),
                        description = countryDetails["description"].ToString()
                    };
                    #pragma warning restore 8601, 8602
                });
            }).ToList();

            return countries ?? new List<Country>();
        }

        private async Task PrintAllJsonContent()
        {
            if (countryList != null && countryList.Count == 0)
                throw new Exception("Empty country list.");

            foreach (var item in countryList!)
            {
                Debug.WriteLine($"[{item.id}] {item.name} - {item.capital} - {item.region}");
                Debug.WriteLine($"Currency: {item.currency.name} - {item.currency.code} - {item.currency.symbol}");
                Debug.WriteLine($"{item.language} - {item.area} - {item.density}");
                Debug.WriteLine(item.description);
                Scene_MainMenu.pictureBox4.BackgroundImage = item.flag;
                await Task.Delay(100);
            }
        }

        // Hide all panels.
        public static void HideAllViews()
        {
            Scene_MainMenu.Visible = false;
            Scene_SelectGamemode.Visible = false;
        }
    }
}