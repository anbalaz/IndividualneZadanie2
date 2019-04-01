using FinishLine.Core.Repository;
using System.Text;

namespace FinishLine.Core.Model
{
    public class Race
    {
        public int NumberofLaps { get; set; }
        public decimal LengthOfLap { get; set; }
        public int NumberOfWinners { get; set; }

        public Race(int numberofLaps, decimal lengthOfLap, int numberOfWinners)
        {
            NumberofLaps = numberofLaps;
            LengthOfLap = lengthOfLap;
            NumberOfWinners = numberOfWinners;
        }

        public Race()
        {
                
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{NumberofLaps}{FileManager.SEPARATOR_PROPERTIES}");
            sb.Append($"{LengthOfLap}{FileManager.SEPARATOR_PROPERTIES}");
            sb.Append($"{NumberOfWinners}{FileManager.SEPARATOR_PROPERTIES}");
          
            return sb.ToString();
        }
    }
}
