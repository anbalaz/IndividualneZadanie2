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
        private const string STATE_FILE_ADDRESS = @"C:\Users\transformer5\Desktop\git\priklady\IndividualneZadanie2\Data\countries.csv";
        private const char VALUE_SEPARATOR = ';';

        public List<State> GetListOFStates()
        {
            int count = 0;
            List<State> States = new List<State>();
            Dictionary<int, State> StatesDictionary = new Dictionary<int, State>();

            using (var streamReader = new StreamReader(STATE_FILE_ADDRESS))
            using (CsvReader csvReader = new CsvReader(streamReader))
            {
                csvReader.ValueSeparator = VALUE_SEPARATOR;
                csvReader.ReadHeaderRecord();
                while (csvReader.HasMoreRecords)
                {
                    var datarecord = csvReader.ReadDataRecord();
                    //States.Add(new StateName(datarecord[COUNTRY_CODE], datarecord[SLOVAK_SHORT_NAME], datarecord[ENGLISH_SHORT_NAME]));
                    StatesDictionary.Add(count++, new State(datarecord[COUNTRY_CODE], datarecord[SLOVAK_SHORT_NAME], datarecord[ENGLISH_SHORT_NAME]));
                }
            }
            return States;
        }

    }
}