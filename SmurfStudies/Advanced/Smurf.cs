namespace SmurfStudies.Advanced;

public class Smurf
{
    private string _name;
    public float Money { get; set; }

    private string[][] _favoriteMeal;

    public Smurf(string name, float money, string[] entry, string[] main, string[] dessert)
    {
        _name = name;
        Money = money;
        _favoriteMeal = new string[3][];
        _favoriteMeal[0] = entry;
        _favoriteMeal[1] = main;
        _favoriteMeal[2] = dessert;
    }
    
    
    public string[] IsFavouriteMeal(Service service)
    {
        return _favoriteMeal[(int)service];
    }
    


    public override string ToString()
    {
        return _name;
    }
}