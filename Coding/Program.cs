class Program
{
    public static PersonList personlist;
    public static FlightList flightlist;
    public static HistoryList historylist;

    public static void Main(string[] args)
    {
        PrepareFlightListWhenProgramIsLoad();
        PreparePersonListWhenProgramIsLoad();
        PrepareHistoryListWhenProgramIsLoad();
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
        Console.WriteLine("=================  Main  Menu  =================");
        Console.WriteLine("1.Login");
        Console.WriteLine("2.Register");
        Console.WriteLine("3.Exit Program");
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
                PrintMenu();
                break;
            case 3:
                Environment.Exit(0);//โคดจบโปรแกรม
                break;
            default:
                Console.WriteLine("Input 1 2 3");
                PrintMenu();
                break;
        }
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
                Console.WriteLine("======================================================");
                Console.Write("You aren't admin.Please Input ID and Password again");
                Console.ReadLine();
                Console.Clear();
                ShowLogin();
            }
            Console.Write("Input the Admin Password : "); 
            string PasswordAdmin = PasswordHide.PasswordHideAdmin(); //PasswordHide for Admin

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
        Console.WriteLine("3.Back To Main Menu");
        Console.WriteLine("================================================");
        Console.Write("Please Input : ");
        string Guest = Console.ReadLine();
        if(Guest == "1" || Guest == "GuestID")
        {
            ShowInsideLoginForGuest();
        }
        else if (Guest == "2"||Guest == "YourID")
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("Input ID ( 'exit' for back to main menu )");
            string id = InputID();
            if(id == "exit")
            {
                PrintMenu();
            }
            Console.Write("Input your Password : ");   
            string password = PasswordHide.PasswordHideUsers(); //PasswordHide for Users

            if(personlist.CheckIDPassword(id,password))
            {
                Console.WriteLine("");
                Console.WriteLine("==============================");
                Console.WriteLine("Not found ID and Password");
                Console.WriteLine("Input ID and Password again");
                Console.ReadLine();
                ShowLoginUser();
            }
            ShowInsideLoginForUser(id);
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
        Console.Write("Please Input : ");
        string select = Console.ReadLine();
        if(select=="1")
        {
            Console.Clear();
            Console.WriteLine("====  Add flight  ====");
            string country = InputCountry();
            double timeOut = InputTimeOut();
            double timeIn = InputTimeIn();
            double price = InputPrice();
            Flight flight = new Flight(country,timeOut,timeIn,price);
            if(flightlist.SelectFlight(country,timeOut,timeIn,price))
            {
                Console.Clear();
                Console.WriteLine("This flight already exists.");
                Console.WriteLine("Do you want to add?(Y/N only)");
                string YesNo = Console.ReadLine();
                if(YesNo == "Y")
                {
                    Program.flightlist.AddNewFlight(flight);
                    Console.WriteLine("===============================");
                    Console.WriteLine("Complete Add flight");
                    Console.WriteLine("Enter to Back to menu admin");
                    Console.ReadLine();
                    ShowInsideLoginForAdmin();
                } 
                else if (YesNo == "N")
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("Cancel Add Flight");
                    Console.WriteLine("Enter to Back to menu admin");
                    Console.ReadLine();
                    ShowInsideLoginForAdmin();
                }
                else
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("Input 'Y' or 'N' only");
                    Console.WriteLine("Enter to Back to menu admin");
                    Console.ReadLine();
                    ShowInsideLoginForAdmin();
                }
            }

            Program.flightlist.AddNewFlight(flight);
            Console.WriteLine("===============================");
            Console.WriteLine("Complete Add flight");
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
        ShowInsideLoginForGuest();
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
    public static void ShowInsideLoginForUser(string id)
    {
        Console.Clear();
        Console.WriteLine("=======================================  Menu Information  =======================================");
        Console.WriteLine("1.Country : Thailand to United States of America || TimeOut : 08:30 - 13:30 || Price : 54,000");
        Console.WriteLine("2.Country : Thailand to Australia || TimeOut : 10:30 - 14:30 || Price : 48,000");
        Console.WriteLine("3.Additional Flight ");
        Console.WriteLine("4.Select Flight");
        Console.WriteLine("5.History");
        Console.WriteLine("6.Logout");

        SelectMenuUser(id);
        ShowInsideLoginForUser(id);
    }
    public static void SelectMenuUser(string id)
    {
        Console.WriteLine("==================================================================================================");
        Console.Write("Please select choice : ");
        int choice = (int.Parse(Console.ReadLine()));
        string country ; double timeOut ; double timeIn ; double price ;
        switch(choice)
        {
            case 1:
                country = "United States of America"; timeOut = 08.30; timeIn = 13.30; price = 54000;
                checkbill(id,country,timeOut,timeIn,price);
                Console.ReadLine();
                break;
            case 2:
                country = "Australia"; timeOut = 10.30; timeIn = 14.30; price = 48000;
                checkbill(id,country,timeOut,timeIn,price);
                Console.ReadLine();
                break;
            case 3:
                Program.flightlist.AdditionalFlight();
                ShowInsideLoginForUser(id);
                break;
            case 4:
                SearchSelectFlight(id);
                ShowInsideLoginForUser(id);
                break;
            case 5:
                Program.historylist.showhistory(id);
                ShowInsideLoginForUser(id);
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
        Console.Clear();
        Console.WriteLine("Which country do you want to travel to?");
        string country = InputCountry();
        if(flightlist.CheckMem(country))
        {
            Console.WriteLine("There are no flights to this country.");
            Console.WriteLine("Wait for admin to add flights to this country later.");
        }
        else
        {
            Program.flightlist.FindFlightCountry(country);
            Console.WriteLine("Other flight not match");
        }
        Console.ReadLine();
    }
    public static void SearchSelectFlight(string id)
    {
        FilterFlight();
        Console.WriteLine("Enter the flight information you want to go on('exit' on country for back to menu)");
        string country = InputCountry();
        if(country == "exit")
        {
            ShowInsideLoginForUser(id);
        }
        double timeOut = InputTimeOut();
        double timeIn = InputTimeIn();
        double price = InputPrice();
                                                                
        if(flightlist.SelectFlight(country,timeOut,timeIn,price))//แก้ในวงเล็บปีกกาเอา country timeOut timeIn price ส่งไปยังเมธอดเช็คบิล(สร้างเมธอดใหม่เขึ้นมา)ที่เชื่อมกับคลาสCalculator
        {
            checkbill(id,country,timeOut,timeIn,price);
            Console.ReadLine();
            ShowInsideLoginForUser(id);
        }

        Console.WriteLine("Not found flight");
        Console.WriteLine("Back to the previous page");
        Console.ReadLine();
    }
    public static void checkbill(string id,string country,double timeOut,double timeIn,double price)
    {
        Console.Clear();
        Console.WriteLine("==========================================================");
        Console.WriteLine("                Input number of passengers                ");
        Console.WriteLine("==========================================================");
        Console.Write("Adult : ");
        double Adult = double.Parse(Console.ReadLine());
        Console.Write("Child : ");
        double Child = double.Parse(Console.ReadLine());
        Console.Write("Baby : ");
        double Baby = double.Parse(Console.ReadLine());
        double totalprice = CalMoney.CalM(Adult,Child,Baby,price);
        Console.WriteLine("Total Price : {0:f2}",totalprice);
        Console.Clear();
        ConfirmBuy(id,country,timeOut,timeIn,totalprice,Adult,Child,Baby);
    }
    public static void ConfirmBuy(string id,string country,double timeOut,double timeIn,double totalprice,double Adult,double Child,double Baby)
    {
        Console.WriteLine("================================================= Check Bill =================================================");
        Console.WriteLine("Country {0} || Time {1:f2} - {2:f2} || Total Price {3:f2} || Adult {4} Child {5} Baby {6}",country,timeOut,timeIn,totalprice,Adult,Child,Baby);
        Console.WriteLine("==============================================================================================================");
        Console.WriteLine("Is it ok to buy?(Y/N)");
        Console.Write(" : ");
        string agree = Console.ReadLine();
        
        if(agree == "Y")
        {
            History history = new History(id,country,timeOut,timeIn,totalprice,Adult,Child,Baby);
            Program.historylist.AddNewHistory(history);
            Console.WriteLine("Order completion");
            Console.ReadLine();
            ShowInsideLoginForUser(id);
        }
        else if (agree == "N")
        {
            Console.WriteLine("Cancel order");
            Console.ReadLine();
            ShowInsideLoginForUser(id);
        }
        Console.WriteLine("Please try again");
        Console.ReadLine();
        Console.Clear();
        ConfirmBuy(id,country,timeOut,timeIn,totalprice,Adult,Child,Baby);
        
    }
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
        Console.WriteLine("======================  Register User  ========================");
        Console.WriteLine("Enter to continue or exit for back to main menu( Write 'exit' )");
        string exit = Console.ReadLine();
        if(exit == "exit")
        {
            PrintMenu();
        }
        Console.Clear();
        Console.WriteLine("==============================");
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

        Person person = new Person(ID,Password,Name,Surname,Number);

        Program.personlist.AddNewPerson(person);
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
        Console.Write("ID card : ");
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
    public static void PrepareHistoryListWhenProgramIsLoad()
    {
        Program.historylist = new HistoryList();
    }
}