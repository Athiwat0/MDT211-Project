class FlightList
{
    private List<Flight> flightlist;

    public FlightList()
    {
        this.flightlist = new List<Flight>();
    }
    public void AddNewFlight(Flight flight)
    {
        this.flightlist.Add(flight);
    }
    public void AdditionalFlight()
    {
        Console.WriteLine("----- List Flight -----");
        foreach(Flight flight in this.flightlist)
        {
            Console.WriteLine("Country {0} Time Out{1}-Time In{2} Price {3}",flight.GetCountry(),flight.GetTimeOut(),flight.GetTimeIn(),flight.GetPrice());
        }
        Console.WriteLine("----- List Flight -----");
        Console.ReadLine();
    }
    public void FindFlightCountry(string country)
    {
        foreach(Flight flight in this.flightlist)
        {
            if (flight.GetCountry()==country)
            {
                Console.WriteLine("Country {0} Time Out{1}-Time In{2} Price {3}",flight.GetCountry(),flight.GetTimeOut(),flight.GetTimeIn(),flight.GetPrice());
            }
        }
    }
    public bool CheckMem(string country)
    {
        foreach(Flight flight in this.flightlist)
        {
            if(flight.GetCountry()==country)
            {
                return false;
            }
        }
        return true;
    }
    public bool SelectFlight(string country,double timeOut,double timeIn,double price)
    {
        foreach(Flight flight in this.flightlist)
        {
            if(flight.GetCountry()==country&&flight.GetTimeOut()==timeOut&&flight.GetTimeOut()==timeIn&&flight.GetPrice()==price)
            {
                return true;
            }
        }
        return false;
    }
}