namespace SwuCube.Core.Tests;

public class RequestsTests
{
    [Test, Explicit]
    public async Task GetExpansions()
    {
        var expansions = await Requests.GetExpansions();
        Assert.That(expansions, Is.Not.Null);
        Assert.That(expansions, Is.Not.Empty);
    }

    [Test]
    public void ParsesExpansionsFromJson()
    {
        var filePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "expansions.txt");
        var content = File.ReadAllText(filePath);
        var expansions = Requests.ParseExpansions(content);
        Assert.That(expansions, Is.Not.Null);
        Assert.That(expansions, Has.Count.EqualTo(6));
        Assert.That(expansions[0].Code, Is.EqualTo("SOR"));
    }
}