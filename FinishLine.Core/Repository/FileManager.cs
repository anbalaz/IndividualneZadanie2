using FinishLine.Core.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace FinishLine.Core.Repository
{
    public class FileManager
    {
        private Race _race = new Race();
        private RunnerRepository runnerRepository = new RunnerRepository();
        private Dictionary<int, Runner> _runnerDictionary = new Dictionary<int, Runner>();

        public const string SEPARATOR_RACE = "---";
        public const char SEPARATOR_PROPERTIES = ';';
        public const string SEPARATOR_START_LAPS = "-{";
        public const string SEPARATOR_END_LAPS = "}-";
        public const char SEPARATOR_LAPS = ',';

        public FileManager()
        {
            //_runnerDictionary = runnerRepository.GetDictionaryOFRunners();
        }

        public void SaveDataToFile(String localDatabase)
        {
            try
            {
                File.WriteAllLines(localDatabase, GetStringFromData());
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private List<string> GetStringFromData()
        {
            List<string> retList = new List<string>();

            foreach (var runner in _runnerDictionary)
            {
                retList.Add($"{runner.Key.ToString()};{runner.Value.ToString()}");
            }
            retList.Add(SEPARATOR_RACE);
            retList.Add(_race.ToString());

            return retList;
        }

        private void GetDataFormString(string data)
        {

        }

        private void AddDataToString(string data)
        {
            string[] propertiesOfRunner = data.Split(SEPARATOR_PROPERTIES);

            List<DateTime> listLapsTime = new List<DateTime>();

            int key = int.Parse(propertiesOfRunner[0]);

            string name = propertiesOfRunner[1];
            int stateOfOrigin = int.Parse(propertiesOfRunner[2]);
            int age = int.Parse(propertiesOfRunner[3]);
            Gender sex = (Gender)Enum.Parse(typeof(Gender), propertiesOfRunner[4]);
            bool isOutOfRace = bool.Parse(propertiesOfRunner[5]);

            if (propertiesOfRunner[6]!= string.Empty)
            {
                string[] arrayLapsTime = propertiesOfRunner[6].Split(SEPARATOR_LAPS);
                foreach (var lapTime in arrayLapsTime)
                {
                    listLapsTime.Add(DateTime.Parse(lapTime));
                }
            }
            _runnerDictionary.Add(key, new Runner(name, stateOfOrigin, age, sex, isOutOfRace, listLapsTime));
        }

        private void AddDataToTime(string data)
        {
            string[] propertiesOfRunner = data.Split(SEPARATOR_PROPERTIES);

            List<DateTime> listLapsTime = new List<DateTime>();

            int numberOfLaps = int.Parse(propertiesOfRunner[0]);

            decimal length = decimal.Parse(propertiesOfRunner[1]);
            int age = int.Parse(propertiesOfRunner[2]);

            _race= new Race(numberOfLaps,length,numberOfLaps);
        }


        public void LoadDataFromFile(String localDatabase)
        {
            try
            {
                string[] lines = File.ReadAllLines(localDatabase);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (!lines[i].Equals( SEPARATOR_RACE))
                    {
                        AddDataToString(lines[i]);
                    }
                    else
                    {
                        AddDataToTime(lines[i+1]);
                        break;
                    }

                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
