using FinishLine.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinishLine.Core.Model
{
    public class Runner
    {
        public string Name { get; set; }
        public int StateOfOrigin { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public bool IsOutOfRace { get; set; }
        private List<DateTime> _finishedLapsTime = new List<DateTime>();

        public Runner(string name, int stateOfOrigin, int age, Gender sex)
        {
            Name = name;
            StateOfOrigin = stateOfOrigin;
            Age = age;
            Sex = sex;
        }

        public Runner(string name, int stateOfOrigin, int age, Gender sex, bool isOutOfRace, List<DateTime> finishedLapsTime) : this(name, stateOfOrigin, age, sex)
        {
            IsOutOfRace = isOutOfRace;
            _finishedLapsTime = finishedLapsTime;
        }

        public void AddLapTime(DateTime dateTime)
        {
            _finishedLapsTime.Add(dateTime);
        }

        public List<DateTime> GetFinishedLapsTime()
        {
            return _finishedLapsTime;
        }

        public int GetLapsCount()
        {
            return _finishedLapsTime.Count;
        }

        public TimeSpan CountDifferenceBetweenLaps()
        {
            return GetFinishedLapsTime().Last() - GetFinishedLapsTime()[GetFinishedLapsTime().Count - 2];
        }

        public TimeSpan CountTimeTotal()
        {
            return GetFinishedLapsTime().Last() - GetFinishedLapsTime().First();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}{FileRepository.SEPARATOR_PROPERTIES}");
            sb.Append($"{StateOfOrigin}{FileRepository.SEPARATOR_PROPERTIES}");
            sb.Append($"{Age}{FileRepository.SEPARATOR_PROPERTIES}");
            sb.Append($"{Sex}{FileRepository.SEPARATOR_PROPERTIES}");
            sb.Append($"{IsOutOfRace}{FileRepository.SEPARATOR_PROPERTIES}");

            for (int i = 0; i < _finishedLapsTime.Count; i++)
            {
                if (i + 1 != _finishedLapsTime.Count)
                {
                    sb.Append($"{_finishedLapsTime[i].ToString()}{FileRepository.SEPARATOR_LAPS}");
                }
                else
                {
                    sb.Append($"{_finishedLapsTime[i].ToString()}");
                }
            }

            return sb.ToString();
        }
    }
}