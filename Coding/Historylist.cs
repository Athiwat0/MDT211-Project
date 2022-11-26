class HistoryList
{
    private List<History> historylist;

    public HistoryList()
    {
        this.historylist = new List<History>();
    }
    public void AddNewHistory(History history)
    {
        this.historylist.Add(history);
    }
    public void showhistory()
    {
        Console.WriteLine("----- List Flight -----");
        foreach(History history in this.historylist)
        {
            Console.WriteLine("Country {0}  Time {1:f2} - {2:f2} Price {3:f2} Adult {4} Child {5} Baby {6}",history.GetCountry(),history.GetTimeOut(),history.GetTimeIn(),history.GetPrice(),history.GetAdult(),history.GetChild(),history.GetBaby());
        }
        Console.WriteLine("----- List Flight -----");
        Console.ReadLine();
    }
    
}