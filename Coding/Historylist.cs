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
    public void showhistory(string id)
    {
        Console.Clear();
        Console.WriteLine("========================================= History Flight =========================================");
        foreach(History history in this.historylist)
        {
            if(history.GetID()==id)
            {
                Console.WriteLine("Country {0} || Time {1:f2} - {2:f2} || Price {3:f2} || Adult {4} Child {5} Baby {6}",history.GetCountry(),history.GetTimeOut(),history.GetTimeIn(),history.GetTotalPrice(),history.GetAdult(),history.GetChild(),history.GetBaby());
            }
        }
        Console.WriteLine("==================================================================================================");
        Console.ReadLine();
    }
    
}