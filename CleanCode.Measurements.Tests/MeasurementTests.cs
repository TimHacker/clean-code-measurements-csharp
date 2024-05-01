namespace CleanCode.Measurements.Tests;

public class MeasurementTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void OneTeaspoonEqualsOneTeaspoon()
    {
        Assert.That(new Teaspoon(1).Equals(new Teaspoon(1)));
    }
    
    [Test]
    public void OneTeaspoonDoesNotEqualTwoTeaspoons()
    {
        Assert.That(new Teaspoon(1).Equals(new Teaspoon(2)));
    }
}

public class Teaspoon
{
    private readonly int _count;

    public Teaspoon(int count)
    {
        _count = count;
    }

    public override bool Equals(object? other)
    {
        if (other is not Teaspoon teaspoon)
        {
            return false;
        }

        return Equals(other);
    }

    public bool Equals(Teaspoon other)
    {
        return true;
    }
}