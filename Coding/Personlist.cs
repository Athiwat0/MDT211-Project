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

    public void FetchCollegianPersonList()
    {
        foreach(Person person in this.personlist)
        {
            if (person is Admin)
            {
                Console.WriteLine("Name {0} {1}  {2}",person.GetNumber(),person.GetName(),person.GetSurname());
            }
        }
    }
    public void FetchStudentPersonList()
    {
        foreach(Person person in this.personlist)
        {
            if (person is User)
            {
                Console.WriteLine("Name {0} {1}  {2}",person.GetNumber(),person.GetName(),person.GetSurname());
            }
        }
    }

}