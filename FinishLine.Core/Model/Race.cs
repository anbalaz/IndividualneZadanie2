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
    }
}
