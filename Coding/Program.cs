class Program
{
    public static PersonList personlist;
    public static FlightList flightlist;

    public static void Main(string[] args)
    {
        PrepareFlightListWhenProgramIsLoad();
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

    public static void ShowLogin()
    {
        string admin1 = "1061";
        string admin2 = "1008";
        Console.Clear();
        string id = InputID();
        string Password = InputPassword();
        Console.WriteLine("Are you admin?(Y/N)");
        string admin = Console.ReadLine();
        if(admin == "Y")
        {
            Console.WriteLine("Secret password");
            string PasswordAdmin = Console.ReadLine();
            if(PasswordAdmin == admin1 || PasswordAdmin == admin2)
            {
                ShowInsideLoginForAdmin();
            }
            Console.WriteLine("You aren't admin.Please Input ID and Password again");
            Console.ReadLine();
            ShowLogin();
        }
        else if (admin == "N")
        {
            ShowInsideLoginForUser();
        }
        ShowLogin();
    }
    public static void ShowInsideLoginForAdmin()
    {
        double price = InputPrice();
        string country = InputCountry();
        double time = InputTime();
        Flight flight = new Flight(price,country,time);

        Program.flightlist.AddNewFlight(flight);

    }
    public static void ShowInsideLoginForUser()
    {
        Console.Clear();
        Console.WriteLine("1.Flight 1 ");
        Console.WriteLine("2.Flight 2 ");
        Console.WriteLine("3.Additional Flight ");
        Console.WriteLine("4.Filter Flight");
        Console.WriteLine("5.Search or Select Flight");
        Console.WriteLine("6.Logout");
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
            case 3:
                Program.flightlist.AdditionalFlight();
                ShowInsideLoginForUser();
                break;
            case 4:
                FilterFlight();
                break;
            case 5:
                SearchSelectFlight();
                break;
            case 6:
                PrintMenu();
                break;
            default:
                break;
        }
    }
    public static void FilterFlight()
    {
        string country = InputCountry();
        if(flightlist.CheckMem(country))
        {
            Console.WriteLine("Nothing ");
            Console.ReadLine();
            ShowInsideLoginForUser();
        }
        Program.flightlist.FindFlightCountry(country);
        Console.WriteLine("Other flight not match");
        
        Console.ReadLine();
        ShowInsideLoginForUser();
    }
    public static void SearchSelectFlight()
    {
        double price = InputPrice();
        string country = InputCountry();
        double time = InputTime();

        if(flightlist.SelectFlight(price,country,time))
        {
            Console.WriteLine("price {0} country {1} time {2}",price*2,country,time);
            Console.ReadLine();
            ShowInsideLoginForUser();
        }
        Console.WriteLine("Not found");
        Console.ReadLine();
        ShowInsideLoginForUser();
    }

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
        string Password = PasswordHide.PasswordUsers();
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
        string Password = PasswordHide.PasswordUsers();
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
    public static double InputPrice()
    {
        Console.Write("Price : ");
        return double.Parse(Console.ReadLine());
    }
    public static string InputCountry()
    {
        Console.Write("Country : ");
        return Console.ReadLine();
    }
    public static double InputTime()
    {
        Console.Write("Time : ");
        return double.Parse(Console.ReadLine());
    }
    public static void PrepareFlightListWhenProgramIsLoad()
    {
        Program.flightlist = new FlightList();
    }
}