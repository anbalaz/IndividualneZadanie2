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
        private List<int> _finishedLapTimeInSeconds = new List<int>();

        public Runner(string name, int stateOfOrigin, int age, Gender sex)
        {
            Name = name;
            StateOfOrigin = stateOfOrigin;
            Age = age;
            Sex = sex;
        }

        public void AddLapTime(int time)
        {
            _finishedLapTimeInSeconds.Add(time);
        }

        public int GetLapsCount()
        {
            return _finishedLapTimeInSeconds.Count;
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