using System.Text;

namespace FinishLine.Core.Model
{
    public class Runner
    {
        public string Name { get; set; }
        public int StateOfOrigin { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }

        public Runner(string name, int stateOfOrigin, int age, Gender sex)
        {
            Name = name;
            StateOfOrigin = stateOfOrigin;
            Age = age;
            Sex = sex;
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
