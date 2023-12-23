namespace SmurfStudies;

public class Person
{
    private string _firstname;
    private string _lastname;
    public string Login { get; private set; }
    
    public Date BirthDate { get; private set; }
    public City Campus { get; set; }

    public Person(string firstname, string lastname, Date birthDate, City campus)
    {
        _firstname = firstname;
        _lastname = lastname;
        BirthDate = birthDate;
        Login = firstname.ToLower() + "." + lastname.ToLower();
        Campus = campus;
    }
}