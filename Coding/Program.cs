public class Program
{
    public static PersonList personlist;
    public static FlightList flightlist;
    public static HistoryList historylist;
     
    public static void Main(string[] args)
    {
        PrepareFlightListWhenProgramIsLoad();
        PreparePersonListWhenProgramIsLoad();
        PrepareHistoryListWhenProgramIsLoad();
        InterfaceMainMenu.PrintMenu();
    }

    public static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personlist = new PersonList();
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