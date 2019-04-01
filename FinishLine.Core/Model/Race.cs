using FinishLine.Core.Repository;
using System.Text;

namespace FinishLine.Core.Model
{
    public class Race
    {
        public int NumberOfLaps { get; set; }
        public decimal LengthOfLap { get; set; }
        public int NumberOfWinners { get; set; }

        public Race(int numberofLaps, decimal lengthOfLap, int numberOfWinners)
        {
            NumberOfLaps = numberofLaps;
            LengthOfLap = lengthOfLap;
            NumberOfWinners = numberOfWinners;
        }

        public Race()
        {
                
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{NumberOfLaps}{FileRepository.SEPARATOR_PROPERTIES}");
            sb.Append($"{LengthOfLap}{FileRepository.SEPARATOR_PROPERTIES}");
            sb.Append($"{NumberOfWinners}{FileRepository.SEPARATOR_PROPERTIES}");
          
            return sb.ToString();
        }
    }
}
