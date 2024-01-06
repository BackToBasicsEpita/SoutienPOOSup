namespace SmurfStudies.Advanced;

public class Table
{
    
    private int _capacity = 0;
    private Smurf[] _chairs;
    private float _total;
    private Service _service = Service.Entry;

    public Table(Smurf[] chairs)
    {
        if (chairs.Length > 4)
            throw new ArgumentException();

        _chairs = chairs;
        _capacity += chairs.Length;
        
        _total = 0;
    }

    public bool WelcomeSmurf()
    {
        return _capacity != 4;
    }
    public void AddCost(float amount)
    {
        _total += amount;
    }

    public float GetSum()
    {
        return _total;
    }

    public void PlaceSmurf(Smurf smurf, int place)
    {
        if (place is < 0 or > 4 || _capacity == 4)
            throw new ArgumentException();

        if (_chairs[place] is null)
            _chairs[place] = smurf;
        else
        {
            (smurf,_chairs[place]) = (_chairs[place], smurf);
            for (int i = 0; i < 4; i++)
            {
                if (_chairs[i] is null)
                    _chairs[i] = smurf;
            }
        }

        _capacity++;
    }

    private void ClearTable()
    {
        _capacity = 0;
        _total = 0;
        _chairs = new Smurf[4];
        _service = Service.Entry;

    }

    private void ChoseMeal(Dictionary<string, float> menu)
    {
        foreach (Smurf smurf in _chairs)
        {
            if (smurf is not null)
            {
                foreach (string meal in smurf.IsFavouriteMeal(_service))
                {
                    if (menu.ContainsKey(meal) && menu[meal] <= smurf.Money)
                    {
                        AddCost(menu[meal]);
                        smurf.Money -= menu[meal];
                        break;
                    }
                }
            }
        }
    }
    
    public float NextService(Dictionary<string, float> menu)
    {

        ChoseMeal(menu);
        
        if (_service == Service.Dessert)
        {
            float ret = GetSum();
            ClearTable();
            return ret;
        }
        _service++;
        return 0;
    }
    
}