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

}