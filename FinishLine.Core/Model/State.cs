namespace FinishLine.Core.Model
{
    public class State
    {
        public string CountryCode { get; set; }
        public string SlovakShortName { get; set; }
        public string EnglishShortName { get; set; }

        public State(string countryCode, string slovakShortName, string englishShortName)
        {
            CountryCode = countryCode;
            SlovakShortName = slovakShortName;
            EnglishShortName = englishShortName;
        }

        public override string ToString()
        {
            return SlovakShortName;
        }
    }
}