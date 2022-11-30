public class InterfaceUser
{
//หน้าเมนูของ User
//หน้าเมนูของ User
//หน้าเมนูของ User
     
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
                InterfaceMainMenu.PrintMenu();
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
        if(Program.flightlist.CheckMem(country))
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
                                                                
        if(Program.flightlist.SelectFlight(country,timeOut,timeIn,price))//แก้ในวงเล็บปีกกาเอา country timeOut timeIn price ส่งไปยังเมธอดเช็คบิล(สร้างเมธอดใหม่เขึ้นมา)ที่เชื่อมกับคลาสCalculator
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