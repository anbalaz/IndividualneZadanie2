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

        public void AddLapTimeToList(DateTime dateTime)
        {
            _finishedLapsTime.Add(dateTime);
        }

        public List<DateTime> GetFinishedLapsTimeList()
        {
            return _finishedLapsTime;
        }

        public int GetFinishedLapsTimeListCount()
        {
            return _finishedLapsTime.Count;
        }
        /// <summary>
        /// returns timeSpan of 2 last DateTime now in _finishedLapsTime 
        /// </summary>
        public TimeSpan CountDifferenceBetweenLaps()
        {
            return GetFinishedLapsTimeList().Last() - GetFinishedLapsTimeList()[GetFinishedLapsTimeList().Count - 2];
        }
        /// <summary>
        /// returns timeSpan between first and last entry _finishedLapsTime 
        /// </summary>
        public TimeSpan CountTimeTotal()
        {
            return GetFinishedLapsTimeList().Last() - GetFinishedLapsTimeList().First();
        }
        /// <summary>
        /// string is calibrated for saving in txt file
        /// </summary>
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