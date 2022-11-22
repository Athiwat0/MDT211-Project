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
            Console.WriteLine("Price {0} Country {1} Time {2}",flight.GetPrice(),flight.GetCountry(),flight.GetTime());
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
                Console.WriteLine("Country {0} {1} {2}",flight.GetPrice(),flight.GetCountry(),flight.GetTime());
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
    public bool SelectFlight(double price,string country,double time)
    {
        foreach(Flight flight in this.flightlist)
        {
            if(flight.GetPrice()==price&&flight.GetCountry()==country&&flight.GetTime()==time)
            {
                return true;
            }
        }
        return false;
    }
}