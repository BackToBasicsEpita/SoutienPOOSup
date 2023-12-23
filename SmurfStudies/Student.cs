namespace SmurfStudies;

public class Student : Person
{
    public int Uid;
    public int Promo;
    
    public Student(string firstname, string lastname, Date birthDate, City campus, int uid, int promo)
        : base(firstname, lastname, birthDate, campus)
    {
        Uid = uid;
        Promo = promo;
    }
}