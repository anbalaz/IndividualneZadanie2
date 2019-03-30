using FinishLine.Core.Model;
using KBCsv;
using System.Collections.Generic;
using System.IO;

namespace FinishLine.Core.Repository
{
    public class StateRepository : IStateRepository
    {
        private const string COUNTRY_CODE = "CountryCode";
        private const string SLOVAK_SHORT_NAME = "SlovakShortName";
        private const string ENGLISH_SHORT_NAME = "EnglishShortName";
        private static string STATE_FILE_ADDRESS = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Data\countries.csv");
        private const char VALUE_SEPARATOR = ';';



        public Dictionary<int, State> GetDictionaryOFStates()
        {
            int count = 1;
            Dictionary<int, State> States = new Dictionary<int, State>();

            States.Add(0, new State(string.Empty, "Unknown", string.Empty));

            using (var streamReader = new StreamReader(STATE_FILE_ADDRESS))
            using (CsvReader csvReader = new CsvReader(streamReader))
            {
                csvReader.ValueSeparator = VALUE_SEPARATOR;
                csvReader.ReadHeaderRecord();
                while (csvReader.HasMoreRecords)
                {
                    var datarecord = csvReader.ReadDataRecord();
                    States.Add(count++, new State(datarecord[COUNTRY_CODE], datarecord[SLOVAK_SHORT_NAME], datarecord[ENGLISH_SHORT_NAME]));
                }
            }
            return States;
        }
    }
}