public class InterfaceAdmin
{
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
            if(Program.flightlist.SelectFlight(country,timeOut,timeIn,price))
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
            InterfaceMainMenu.PrintMenu();
        }
        Console.WriteLine("===============================");
        Console.Write("Please select ( 1 or 2 )");
        Console.ReadLine();
        ShowInsideLoginForAdmin();

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
 
}