using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace LinkedListsTests;

public class UnitTest1
{
   
    [Test]
    public void Test1()
    {
        var lines = new[]
        {
            "a->b",
            "r->s",
            "b->c",
            "x->c",
            "q->r",
            "y->x",
            "w->z",
            "a, q, w",
            "a, c, r",
            "y, z, a, r",
            "a, w"
        };

        var expectedResults = new[]
        {
            "False",
            "True",
            "True",
            "False"
        };

        var results = Testing.Main(lines).ToArray();

        Assert.That(results,Is.EqualTo(expectedResults));
    }

    [Fact]
    public void Test2()
    {
        var lines = new[]
        {
            "A->B",
            "G->B",
            "B->C",
            "C->D",
            "D->E",
            "H->J",
            "J->F",
            "A, G, E",
            "H, A"
        };

        var expectedResults = new[]
        {
            "True",
            "False"
        };

        var results = Testing.Main(lines).ToArray();

        Assert.That(results,Is.EqualTo(expectedResults));
    }

    [Fact]
    public void Test3()
    {
        var lines = new[]
        {
            "ABC->BCD",
            "BCD->CDE",
            "DEF->EFG",
            "EFG->BCD",
            "123->456",
            "ABC, CDE",
            "123, DEF",
            "ABC, DEF"
        };

        var expectedResults = new[]
        {
            "True",
            "False",
            "True"
        };

        var results = Testing.Main(lines).ToArray();

        Assert.That(results,Is.EqualTo(expectedResults));
    }

    [Fact]
    public void Test4()
    {
        var lines = new[]
        {
            "X->Y",
            "Y->X",
            "A->B",
            "B->C",
            "X, A"
        };

        var expectedResults = new[]
        {
            "Error Thrown!"
        };

        var results =Testing.Main(lines).ToArray();

        Assert.That(results,Is.EqualTo(expectedResults));
    }
}
