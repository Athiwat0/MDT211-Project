public class InterfaceMainMenu
{
    //หน้าเมนูหลักของโปรแกรม
//หน้าเมนูหลักของโปรแกรม
//หน้าเมนูหลักของโปรแกรม
     
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
                InterfaceLogin.ShowLogin();
                Console.Clear();
                break;
            case 2:
                InterfaceRegister.ShowInputUser();
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
 
}