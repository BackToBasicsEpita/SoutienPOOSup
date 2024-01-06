namespace SmurfStudies.Advanced;

public class Resto
{
    private Dictionary<string, float> Menu { get; set; }
    private Queue<Smurf> _queue;
    private int _nbCustomers;
    private int _capacity;
    private List<Table> _tables;
    public float Benefits { get; set; }
    
    public Resto(int nbTables, Dictionary<string,float> menu)
    {
        Menu = menu;
        _queue = new Queue<Smurf>(nbTables);
        _capacity = nbTables * 4;
        _tables = new List<Table>(nbTables);
        Benefits = 0;
        _nbCustomers = 0;
    }


    private void PlaceCustomer(Smurf smurf, int place)
    {
        int index = 0;

        while (index < _tables.Count && _tables[index].WelcomeSmurf())
        {
            index++;
        }
        _tables[index].PlaceSmurf(smurf, place);
    }
    
    
    public void AddGroup(List<Smurf> group)
    {
        if (_nbCustomers + _queue.Count + group.Count > _capacity + _tables.Count)
            throw new ArgumentException();
        
        int index = 0;
        
        while (index < group.Count && _nbCustomers < _capacity)
        {
            PlaceCustomer(group[index], index % 4);
            index++;
        }

        for (; index < group.Count; index++)
            _queue.Enqueue(group[index]);
        
    }

    public void NextService()
    {
        float diff;
        int acc = 0;
        
        for (int i = 0; i < _tables.Count; i++)
        {
            diff = _tables[i].NextService(Menu);
            if (diff != 0)
            {
                while (_queue.Count > 0 && acc < 4)
                {
                    _tables[i].PlaceSmurf(_queue.Dequeue(), acc);
                    acc++;
                }

                Benefits += diff;
            }
        }
    }
    
}