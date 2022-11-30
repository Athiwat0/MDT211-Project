public class InterfaceGuest
{
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
                InterfaceUser.FilterFlight();
                ShowInsideLoginForGuest();
                break;
            case 3:
                InterfaceMainMenu.PrintMenu();
                break;
            default:
                break;
        }
    }
 
}