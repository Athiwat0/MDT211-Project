namespace testFinal;

public class UnitTestProgram
{
//    [Fact]
//     public void TestCreateInputID() 
//     {
//         string ID = Program.InputID();

//         Assert.IsType<string>(ID);
//     }
//     [Fact]
//     public void TestCreateInputPassword() 
//     {
//         string Password = Program.InputPassword();

//         Assert.IsType<string>(Password);
//     }
//     [Fact]
//     public void TestCreateInputName() 
//     {
//         string Name = Program.InputName();

//         Assert.IsType<string>(Name);
//     }
    // [Fact]
    // public void TestCreateInputSurname() 
    // {
    //     string Surname = Program.InputSurname();

    //     Assert.IsType<string>(Surname);
    // }
    public void TestCreateInputNumber() 
    {
        string Number = Program.InputNumber();

        Assert.IsType<string>(Number);
    }
    public void TestCreateInputPrice() 
    {
        double Price = Program.InputPrice();

        Assert.IsType<double>(Price);
    }
    public void TestCreateInputCountry() 
    {
        string Country = Program.InputCountry();

        Assert.IsType<string>(Country);
    }
    public void TestCreateInputTimeIn() 
    {
        double TimeIn = Program.InputTimeIn();

        Assert.IsType<double>(TimeIn);
    }
    public void TestCreateInputTimeOut() 
    {
        double TimeOut = Program.InputTimeOut();

        Assert.IsType<double>(TimeOut);
    }


}