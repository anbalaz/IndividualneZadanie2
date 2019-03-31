using System;
using System.Collections.Generic;
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
        private List<DateTime> _finishedLapTime = new List<DateTime>();

        public Runner(string name, int stateOfOrigin, int age, Gender sex)
        {
            Name = name;
            StateOfOrigin = stateOfOrigin;
            Age = age;
            Sex = sex;
        }

        public void AddLapTime(DateTime dateTime)
        {
            _finishedLapTime.Add(dateTime);
        }

        public List<DateTime> GetFinishedLapTime()
        {
            return _finishedLapTime;
        }

        public int GetLapsCount()
        {
            return _finishedLapTime.Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(StateOfOrigin);
            sb.Append(Age);
            sb.Append(Sex);
            return sb.ToString();
        }
    }
}