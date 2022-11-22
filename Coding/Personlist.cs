class PersonList
{
    private List<Person> personlist;

    public PersonList()
    {
        this.personlist = new List<Person>();
    }
    public void AddNewPerson(Person person)
    {
        this.personlist.Add(person);
    }
    public bool findID(string ID)
    {
        foreach(Person person in this.personlist)
        {
            if (person.GetID()==ID)
            {
                return true;
            }
        }
        return false;
    }
    public bool CheckIDPassword(string ID,string Password)
    {
        foreach(Person person in this.personlist)
        {
            if (person.GetID()==ID&&person.GetPassword()==Password)
            {
                return false;
            }
        }
        return true;
    }

}