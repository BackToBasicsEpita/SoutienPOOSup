namespace SmurfStudies;

public class Date
{
    private int _day;
    private int _month;
    private int _year;
    
    public int Day
    {
        get => _day;
        set
        {
            if (value > 31 || value < 0)
                throw new ArgumentException();
            _day = value;
        }
    }
    public int Month
    {
        get => _month;
        set
        {
            if (value > 12 || value < 0)
                throw new ArgumentException();
            _month = value;
        }
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public Date(int day, int month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }
}