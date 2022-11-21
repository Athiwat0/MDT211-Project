class Program
{
    public static PersonList personlist;
    public static FlightList flightlist;

    public static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintMenu();
    }
    public static void PrintMenu()
    {
        PrintListMenuLogout();
        PresentMenuLogout();
    }
    public static void PrintListMenuLogout()
    {
        Console.Clear();
        Console.WriteLine("----- Menu idea camp 2022 -----");
        Console.WriteLine("1.Login");
        Console.WriteLine("2.Register");
        Console.WriteLine("-------------------------------");

    }
    public static void PresentMenuLogout()
    {
        Console.Write("Please select menu : ");
        int menuLogout = (int.Parse(Console.ReadLine()));
        switch (menuLogout)
        {
            case 1:
                ShowLogin();
                break;
            case 2:
                InputRegisterUser();
                break;
            default:
                break;
        }
        PrintMenu();

    }
    public static void PrintListMenuLogin()
    {
        Console.Clear();
        Console.WriteLine("----- Menu idea camp 2022 -----");
        Console.WriteLine("1.Register Idea Camp 2022");
        Console.WriteLine("2.Logout");
        Console.WriteLine("-------------------------------");
    }
    public static void InputMenuLoginFromKeyboard()
    {
        PresentMenuLogin();
    }
    public static void PresentMenuLogin()
    {
        Console.Write("Please select menu : ");
        int menuLogin = (int.Parse(Console.ReadLine()));
        switch (menuLogin)
        {
            case 1:
                InputRegisterUser();
                break;
            case 2:
                PrintMenu();
                break;
            default:
                break;
        }
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();

    }

    public static void ShowLogin()
    {
        Console.Clear();
        Console.WriteLine("Write < exit > for out");
        string id = InputID();
        string Password = InputPassword();
        Console.WriteLine("Are you admin?(Y/N)");
        string admin = Console.ReadLine();
        if(admin == "Y")
        {
            ShowInsideLoginForAdmin();
        }
        else if (admin == "N")
        {
            ShowInsideLoginForUser();
        }
        ShowLogin();
    }
    public static void ShowInsideLoginForAdmin()
    {
        string price = InputPrice();
        string country = InputCountry();
        string time = InputTime();
        Flight flight = new Flight(price,country,time);

        Program.flightlist.AddNewFlight(flight);

    }
    public static void ShowInsideLoginForUser()
    {
        Console.Clear();
        Console.WriteLine("1.Flight 1 ");
        Console.WriteLine("2.Flight 2 ");
        Console.WriteLine("3.Search ");

        SelectMenuUser();
        ShowInsideLoginForUser();
    }
    public static void SelectMenuUser()
    {
        Console.Write("Please select choice : ");
        int choice = (int.Parse(Console.ReadLine()));
        switch(choice)
        {
            case 1:
                Console.WriteLine("Flight 1");
                Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Flight 2");
                Console.ReadLine();
                break;
            //case 3:
            //    SearchFlight();
            //    break;
            default:
                break;
        }
    }
    //public static void SearchFlight()
    //{
    //    string country = InputCountry();
    //
    //    Program.flightlist.FetchFlight(country);
    //    Console.ReadLine();
    //    ShowInsideLoginForUser();
    //}

    public static void InputRegisterUser()
    {
        Console.Clear();
        PrintMenuRegister();
        PresentMenuRegister();

    }
    
    public static void PrintMenuRegister()
    {
        Console.WriteLine("1.User");
        Console.WriteLine("2.Admin");
    }
    public static void PresentMenuRegister()
    {
        Console.Write("Please select group : ");
        int menuregis = (int.Parse(Console.ReadLine()));
        switch(menuregis)
        {
            case 1:
                ShowInputUser();
                break;
            case 2:
                ShowInputAdmin();
                break;
            default:
                break;
        }
    }
    public static void ShowInputUser()
    {
        Console.Clear();
        Console.WriteLine("Register User");
        string ID = InputID();
        if(personlist.findID(ID))
        {
            Console.WriteLine("Input ID Again");
            Console.ReadLine();
            ShowInputUser();
            return;
        }
        string Password = InputPassword();
        string Name = InputName();
        string Surname = InputSurname();
        string Number = InputNumber();

        Admin admin = new Admin(ID,Password,Name,Surname,Number);

        Program.personlist.AddNewPerson(admin);
    }

    public static void ShowInputAdmin()
    {
        Console.Clear();
        Console.WriteLine("Register Admin");
        string ID = InputID();
        if(personlist.findID(ID))
        {
            Console.WriteLine("Input ID Again");
            Console.ReadLine();
            ShowInputAdmin();
            return;
        }
        string Password = InputPassword();
        string Name = InputName();
        string Surname = InputSurname();
        string Number = InputNumber();

        User user = new User(ID,Password,Name,Surname,Number);
        

        Program.personlist.AddNewPerson(user);
    }

    public static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personlist = new PersonList();
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
        Console.Write("Number : ");
        return Console.ReadLine();
    }
    public static string InputPrice()
    {
        Console.Write("Price : ");
        return Console.ReadLine();
    }
    public static string InputCountry()
    {
        Console.Write("Country : ");
        return Console.ReadLine();
    }
    public static string InputTime()
    {
        Console.Write("Time : ");
        return Console.ReadLine();
    }
}