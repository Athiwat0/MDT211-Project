public class InterfaceRegister
{
//หน้าที่แสดงและรับค่าตอนกรอกข้อมูล Register
//หน้าที่แสดงและรับค่าตอนกรอกข้อมูล Register
//หน้าที่แสดงและรับค่าตอนกรอกข้อมูล Register
    public static void ShowInputUser()
    {
        Console.Clear();
        Console.WriteLine("                         Question For Register                          ");
        Console.WriteLine("========================================================================");
        Console.WriteLine("Enter to answer questions or exit for back to main menu( Write 'exit' ) ");
        Console.Write(" : ");
        string exit = Console.ReadLine();
        if(exit == "exit")
        {
            InterfaceMainMenu.PrintMenu();
        }
        Console.Clear();
        Console.WriteLine("How many doses of vaccine have you received?");
        Console.Write(" : ");
        int vaccine = int.Parse(Console.ReadLine());
        if(vaccine < 3)
        {
            Console.WriteLine("You can't register but you will have a Guest ID to see something");
            Console.WriteLine("If you write something else, it will go back to the previous page.");
            Console.WriteLine("will you take it?(Y/N)");
            string takeGuest = Console.ReadLine();
            if(takeGuest == "Y")
            {
                InterfaceGuest.ShowInsideLoginForGuest();
            }
            else if(takeGuest == "N")
            {
                InterfaceMainMenu.PrintMenu();
            }
            ShowInputUser();
        }
        InputInfo();
    }

    public static void InputInfo()
    {
        Console.Clear();
        Console.WriteLine("======================  Register User  ========================");
        Console.WriteLine("Enter to continue or exit for back to main menu( Write 'exit' )");
        string exit = Console.ReadLine();
        if(exit == "exit")
        {
            InterfaceMainMenu.PrintMenu();
        }
        Console.Clear();
        Console.WriteLine("==============================");
        Console.WriteLine("Please enter this information.");
        Console.WriteLine("==============================");
        string ID = InputID();
        if(Program.personlist.findID(ID))
        {
            Console.WriteLine("Input ID Again");
            Console.ReadLine();
            InputInfo();
            return;
        }
        string Password = PasswordHide.PasswordUsers();
        string Name = InputName();
        string Surname = InputSurname();
        string Number = InputNumber();

        Person person = new Person(ID,Password,Name,Surname,Number);

        Program.personlist.AddNewPerson(person);
        InterfaceMainMenu.PrintMenu();
    }
    public static string InputID()
    {
        Console.Write("ID : ");
        return Console.ReadLine();
    }
    public static string InputPassword()
    {
        Console.Write("Password : ");
        return Console.ReadLine();
    }
    public static string InputName()
    {
        Console.Write("Name : ");
        return Console.ReadLine();
    }
    public static string InputSurname()
    {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }
    public static string InputNumber()
    {
        Console.Write("ID card : ");
        return Console.ReadLine();
    }
 
}