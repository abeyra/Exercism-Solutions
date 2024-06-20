public class Lasagna
{
    public int ExpectedMin => 40;
    public int ExpectedMinutesInOven()
        => ExpectedMin;
    public int RemainingMinutesInOven(int minSoFar)
        => ExpectedMin - minSoFar;
    public int PreparationTimeInMinutes(int numberOfLayers)
        => numberOfLayers * 2;
    public int ElapsedTimeInMinutes(int numberOfLayers, int minInOven)
        => PreparationTimeInMinutes(numberOfLayers) + minInOven;
}
