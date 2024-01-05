namespace SmurfStudies;

public class Prof : Person
{
    public List<Subject> PreferredSubjects { get; set; }

    public Prof(string firstname, string lastname, Date birthDate, City campus, List<Subject> subjects)
        : base(firstname, lastname, birthDate, campus)
    {
        PreferredSubjects = subjects;
    }

    private void AddSubject(Subject subject)
    {
        PreferredSubjects.Add(subject);
    }
}