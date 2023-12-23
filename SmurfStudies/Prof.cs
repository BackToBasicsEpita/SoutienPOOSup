namespace SmurfStudies;

public class Prof : Person
{
    public List<Subject> preferedSubjects { get; set; }

    public Prof(string firstname, string lastname, Date birthDate, City campus, List<Subject> subjects)
        : base(firstname, lastname, birthDate, campus)
    {
        preferedSubjects = subjects;
    }
}