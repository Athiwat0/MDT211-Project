namespace testFinal;

public class UnitTestPerson
{
    Person mockNewPerson = new Person("Jamesbond", "007" , "James" , "Bond","1111111111111");

    [Fact]
    public void TestCreateNewPerson() 
    {
        Assert.IsType<Person>(mockNewPerson);
    }

    [Fact]
    public void TestEqualGetID() 
    {
        Assert.Equal(mockNewPerson.GetID(), "Jamesbond");
    }
   [Fact]
    public void TestNotEqualGetID() 
    {
        Assert.NotEqual(mockNewPerson.GetID(), "Japan");
    }


    [Fact]
    public void TestEqualGetPassword() 
    {
        Assert.Equal(mockNewPerson.GetPassword(), "007");
    }
    [Fact]
    public void TestNotEqualGetPasswordt() 
    {
        Assert.NotEqual(mockNewPerson.GetPassword(), "777");
    }

    [Fact]
    public void TestEqualGetName() 
    {
        Assert.Equal(mockNewPerson.GetName(), "James");
    }
    [Fact]
    public void TestNotEqualGetName() 
    {
        Assert.NotEqual(mockNewPerson.GetName(), "Jame");
    }

    [Fact]
    public void TestEqualGetSurname() 
    {
        Assert.Equal(mockNewPerson.GetSurname(), "Bond");
    }
    [Fact]
    public void TestNotEqualGetSurname() 
    {
        Assert.NotEqual(mockNewPerson.GetSurname(), "Born");
    }  
    [Fact]
    public void TestEqualGetIDcard() 
    {
        Assert.Equal(mockNewPerson.GetIDcard(), "1111111111111");
    }
    [Fact]
    public void TestNotEqualGetIDcard() 
    {
        Assert.NotEqual(mockNewPerson.GetIDcard(), "7777777777777");
    }  
}