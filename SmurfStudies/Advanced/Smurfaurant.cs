namespace SmurfStudies.Advanced;

public class Resto
{
    private Dictionary<string, float> Menu { get; set; }
    private Queue<Smurf> _queue;
    private int _capacity;
    private List<Table> _tables;
    
    public Resto(int capacity, int nbTables, Dictionary<string,float> menu)
    {
        Menu = menu;
        _queue = new Queue<Smurf>(capacity / 4);
        _capacity = capacity;
        _tables = new List<Table>(nbTables);

    }
    
    
}