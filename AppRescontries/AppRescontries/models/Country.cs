using System.Collections.Generic;

namespace AppRescontries.Models
{

    public class Country
    {
        public Name Name { get; set; }
        public string Cca2 { get; set; }
        public string FlagUrl => $"https://flagcdn.com/w320/{Cca2.ToLower()}.png";
        public string[] Capital { get; set; }
        public Dictionary<string, string> Languages { get; set; }
        public Dictionary<string, Currency> Currencies { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
    }

    public class Name
    {
        public string Common { get; set; }
        public string Official { get; set; }
    }

    public class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }



}
