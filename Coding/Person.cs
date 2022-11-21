class Person
{
    private string ID;
    private string Password;
    private string Name;
    private string Surname;
    private string Number;

    public Person(string ID,string Password,string Name,string Surname,string Number)
    {
        this.ID = ID;
        this.Password = Password;
        this.Name = Name;
        this.Surname = Surname;
        this.Number = Number;
    }
    public string GetID()
    {
        return this.ID;
    }
    public string GetPassword()
    {
        return this.Password;
    }
    public string GetName()
    {
        return this.Name;
    }
    public string GetSurname()
    {
        return this.Surname;
    }
    public string GetNumber()
    {
        return this.Number;
    }
}