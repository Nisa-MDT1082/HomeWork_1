namespace TestHW;

public class UnitTest1
{
    [Fact]
    public void Test_Name()
    {
        var money = new Store("nisa",100, "money",10000);
        Assert.Equal("nisa", money.Name);
    }

[Fact]
public void Test_Number()
{
    var money = new Store("nisa",100, "money",10000);
    money.Number += 100;
    Assert.Equal(200, money.Number);
}

[Fact]
public void Test_OwnerName()
{
   var money = new Store("nisa",100, "money",10000);
   Assert.Equal("money", money.OwnerName);
}

[Fact]
public void Test_RegisteredValue()
{
    var money = new Store("nisa",100, "money",10000);
    money.RegisteredValue += 5000;
    Assert.Equal(15000, money.RegisteredValue);
}
}