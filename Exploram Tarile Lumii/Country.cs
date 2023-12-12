namespace Exploram_Tarile_Lumii
{
    public class Country
    {
        public struct Currency
        {
            public Currency() { }

            public string name { get; set; } = String.Empty;
            public string code { get; set; } = String.Empty;
            public string symbol { get; set; } = String.Empty;
        }

        public int id { get; set; }
        public string name { get; set; } = String.Empty;
        public string capital { get; set; } = String.Empty;
        public string region { get; set; } = String.Empty;
        public Currency currency;
        public string language { get; set; } = String.Empty;
        public Bitmap? flag { get; set; } = null;
        public string area { get; set; } = String.Empty;
        public string density { get; set; } = String.Empty;
        public string description { get; set; } = String.Empty;
    }
}
