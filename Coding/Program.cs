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
        Console.WriteLine("    Welcome to air ticket booking program   ");
        Console.WriteLine("==============  Menu Information  ==============");
        Console.WriteLine("1.Login");
        Console.WriteLine("2.Register");
        Console.WriteLine("================================================");
    }
    public static void PresentMenuLogout()
    {
        Console.Write("Please select menu : ");
        int menuLogout = (int.Parse(Console.ReadLine()));
        Console.Clear();
        switch (menuLogout)
        {
            case 1:
                ShowLogin();
                Console.Clear();
                break;
            case 2:
                ShowInputUser();
                break;
            default:
                break;
        }
        PrintMenu();
    }
    public static void ShowLogin()
    {
        string[] IDAdmin = new string[] {"Pan","Mick","Deil"};
        string[] PassAdmin = new string[] {"1008","1061","1066"};
        Console.WriteLine("Are you admin?(Y/N)");
        Console.Write(" : ");
        string admin = Console.ReadLine();
        if(admin == "Y")
        {
            Console.Clear();
            Console.Write("Input Admin ID : ");
            string AdminID = Console.ReadLine();
            if(AdminID == "Pan" || AdminID == "Mick" || AdminID == "Deil");           
            else
            {
                ShowLogin();
            }
            Console.Write("Input the Admin Password : ");
            string PasswordAdmin = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                break;
                PasswordAdmin += key.KeyChar;
                }

            if(AdminID == IDAdmin[0] && PasswordAdmin == PassAdmin[0])
            {
                ShowInsideLoginForAdmin();
            }
            else if(AdminID == IDAdmin[1] && PasswordAdmin == PassAdmin[1])
            {
                ShowInsideLoginForAdmin();
            }
            else if(AdminID == IDAdmin[2] && PasswordAdmin == PassAdmin[2])
            {
                ShowInsideLoginForAdmin();
            }
            Console.WriteLine("");
            Console.WriteLine("======================================================");
            Console.WriteLine("You aren't admin.Please Input ID and Password again");
            Console.ReadLine();
            Console.Clear();
            ShowLogin();
        }
        else if (admin == "N")
        {
            ShowLoginUser();
        }
        Console.WriteLine("===============================");
        Console.Write("Please try again.");
        Console.ReadLine();
        Console.Clear();
        ShowLogin();
    }
    public static void ShowLoginUser()
    {
        Console.Clear();
        Console.WriteLine("==============  Menu Information  ==============");
        Console.WriteLine("1.GuestID");
        Console.WriteLine("2.YourID");
        Console.WriteLine("3.Exit");
        Console.WriteLine("================================================");
        Console.Write("Please Input : ");
        string Guest = Console.ReadLine();
        if(Guest == "1" || Guest == "GuestID")
        {
            ShowInsideLoginForGuest();
        }
        else if (Guest == "2"||Guest == "YourID")
        {
            Console.WriteLine("Input ID ( 'exit' for back )");
            string id = InputID();
            if(id == "exit")
            {
                PrintMenu();
            }
            Console.Write("Input your Password : ");
            string password = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                break;
                password += key.KeyChar;
            }
            if(personlist.CheckIDPassword(id,password))
            {
                Console.WriteLine("");
                Console.WriteLine("==============================");
                Console.WriteLine("Not found ID and Password");
                Console.WriteLine("Input ID and Password again");
                Console.ReadLine();
                ShowLoginUser();
            }
            ShowInsideLoginForUser();
        }
        else if(Guest == "3" || Guest == "exit")
        {
            PrintMenu();
        }
        Console.WriteLine("Please select ( 1 or 2 or 3 )");
        Console.ReadLine();
        ShowLoginUser();
    }
    public static void ShowInsideLoginForAdmin()
    {
        Console.Clear();
        Console.WriteLine("=====  Menu Admin  =====");
        Console.WriteLine("1.Add flight");
        Console.WriteLine("2.Logout");
        Console.WriteLine("========================");
        string select = Console.ReadLine();
        if(select=="1")
        {
            Console.Clear();
            Console.WriteLine("====  Add flight  ====");
            double price = InputPrice();
            string country = InputCountry();
            double timeOut = InputTimeOut();
            double timeIn = InputTimeIn();
            Flight flight = new Flight(country,timeOut,timeIn,price);

            Program.flightlist.AddNewFlight(flight);
            Console.WriteLine("===============================");
            Console.WriteLine("Enter to Back to menu admin");
            Console.ReadLine();
            ShowInsideLoginForAdmin();
        }
        else if(select == "2")
        {
            PrintMenu();
        }
        Console.WriteLine("===============================");
        Console.Write("Please select ( 1 or 2 )");
        Console.ReadLine();
        ShowInsideLoginForAdmin();

    }
    public static void ShowInsideLoginForGuest()
    {
        Console.Clear();
        Console.WriteLine("1.Additional Flight ");
        Console.WriteLine("2.Filter Flight");
        Console.WriteLine("3.Logout");
        SelectMenuGuest();
        ShowInsideLoginForUser();
    }
    public static void SelectMenuGuest()
    {
        Console.WriteLine("===============================");
        Console.Write("Please select choice : ");
        int choice = (int.Parse(Console.ReadLine()));
        switch(choice)
        {
            case 1:
                Program.flightlist.AdditionalFlight();
                ShowInsideLoginForGuest();
                break;
            case 2:
                FilterFlight();
                ShowInsideLoginForGuest();
                break;
            case 3:
                PrintMenu();
                break;
            default:
                break;
        }
    }
    public static void ShowInsideLoginForUser()
    {
        Console.Clear();
        Console.WriteLine("1.Country : Thailand to United States of America || TimeOut : 08:30 || Price : xxxxx");
        Console.WriteLine("2.Country : Thailand to Australia || TimeOut : 10:30 || Price : xxxxx");
        Console.WriteLine("3.Additional Flight ");
        Console.WriteLine("4.Select Flight");
        Console.WriteLine("5.Logout");
        SelectMenuUser();
        ShowInsideLoginForUser();
    }
    public static void SelectMenuUser()
    {
        Console.WriteLine("===============================");
        Console.Write("Please select choice : ");
        int choice = (int.Parse(Console.ReadLine()));
        switch(choice)
        {
            case 1:
                Console.WriteLine("Flight 1");//ประกาศและส่งตัวแปรไปยังเมธอดเชคบิล
                Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Flight 2");//ประกาศและส่งตัวแปรไปยังเมธอดเชคบิล
                Console.ReadLine();
                break;
            case 3:
                Program.flightlist.AdditionalFlight();
                ShowInsideLoginForUser();
                break;
            case 4:
                SearchSelectFlight();
                ShowInsideLoginForUser();
                break;
            case 5:
                PrintMenu();
                break;
            default:
                break;
        }
    }
    public static void FilterFlight()
    {
        Console.WriteLine("Which country do you want to travel to?");
        string country = InputCountry();
        if(flightlist.CheckMem(country))
        {
            Console.WriteLine("Nothing ");
        }
        else
        {
            Program.flightlist.FindFlightCountry(country);
            Console.WriteLine("Other flight not match");
        }
        Console.ReadLine();
    }
    public static void SearchSelectFlight()
    {
        FilterFlight();
        string country = InputCountry();
        double timeOut = InputTimeOut();
        double timeIn = InputTimeIn();
        double price = InputPrice();
                                                                
        if(flightlist.SelectFlight(country,timeOut,timeIn,price))//แก้ในวงเล็บปีกกาเอา country timeOut timeIn price ส่งไปยังเมธอดเช็คบิล(สร้างเมธอดใหม่เขึ้นมา)ที่เชื่อมกับคลาสCalculator
        {
            Console.WriteLine("country {0} time {1} - {2} price {3} ",country,timeOut,timeIn,price);//โดยเมธอดเชคบิลจะถามจำนวนเด็กและผู้ใหบ๋ด้วย baby ราคา 10% ของผู้ใหญ่ child ราคา 75% ของผู้ใหญ่ ผู้ใหญ่ 100%
            Console.ReadLine();
        }
        Console.WriteLine("Not found");
        Console.ReadLine();
    }
    
    public static void ShowInputUser()
    {
        Console.Clear();
        Console.WriteLine("              Question for Register                ");
        Console.WriteLine("===================================================");
        Console.WriteLine("Enter to answer questions or exit ( Write 'exit' ) ");
        Console.Write(" : ");
        string exit = Console.ReadLine();
        if(exit == "exit")
        {
            PrintMenu();
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
                ShowInsideLoginForGuest();
            }
            else if(takeGuest == "N")
            {
                PrintMenu();
            }
            ShowInputUser();
        }
        InputInfo();
    }
    public static void InputInfo()
    {
        Console.Clear();
        Console.WriteLine("===========  Register User  =============");
        Console.WriteLine("Enter to continue or exit ( Write 'exit' )");
        string exit = Console.ReadLine();
        if(exit == "exit")
        {
            PrintMenu();
        }
        Console.Clear();
        Console.WriteLine("Please enter this information.");
        Console.WriteLine("==============================");
        string ID = InputID();
        if(personlist.findID(ID))
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
    public static double InputTimeIn()
    {
        Console.Write("Time In : ");
        return double.Parse(Console.ReadLine());
    }
    public static double InputTimeOut()
    {
        Console.Write("Time Out : ");
        return double.Parse(Console.ReadLine());
    }
    public static void PrepareFlightListWhenProgramIsLoad()
    {
        Program.flightlist = new FlightList();
    }
}