public class InterfaceLogin
{
//หน้าเมนูล็อกอิน
//หน้าเมนูล็อกอิน
//หน้าเมนูล็อกอิน
     
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
                InterfaceAdmin.ShowInsideLoginForAdmin();
            }
            else if(AdminID == IDAdmin[1] && PasswordAdmin == PassAdmin[1])
            {
                InterfaceAdmin.ShowInsideLoginForAdmin();
            }
            else if(AdminID == IDAdmin[2] && PasswordAdmin == PassAdmin[2])
            {
                InterfaceAdmin.ShowInsideLoginForAdmin();
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
     
//หน้าเมนูล็อกอินของ User
//หน้าเมนูล็อกอินของ User
//หน้าเมนูล็อกอินของ User
     
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
            InterfaceGuest.ShowInsideLoginForGuest();
        }
        else if (Guest == "2"||Guest == "YourID")
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("Input ID ( 'exit' for back to main menu )");
            string id = InputID();
            if(id == "exit")
            {
                InterfaceMainMenu.PrintMenu();
            }
            Console.Write("Input your Password : ");   
            string password = PasswordHide.PasswordHideUsers(); //PasswordHide for Users

            if(Program.personlist.CheckIDPassword(id,password))
            {
                Console.WriteLine("");
                Console.WriteLine("==============================");
                Console.WriteLine("Not found ID and Password");
                Console.WriteLine("Input ID and Password again");
                Console.ReadLine();
                ShowLoginUser();
            }
            InterfaceUser.ShowInsideLoginForUser(id);
        }
        else if(Guest == "3" || Guest == "exit")
        {
            InterfaceMainMenu.PrintMenu();
        }
        Console.WriteLine("Please select ( 1 or 2 or 3 )");
        Console.ReadLine();
        ShowLoginUser();
    }
    public static string InputID()
    {
        Console.Write("ID : ");
        return Console.ReadLine();
    }
 
}