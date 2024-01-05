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
            if (!IsDate(value, _month,_year))
                throw new ArgumentException();
            _day = value;
        }
    }
    public int Month
    {
        get => _month;
        set
        {
            if (!IsDate(_day, value,_year))
                throw new ArgumentException();
            _month = value;
        }
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    private bool IsLeapYear(int year)
    {
        if((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            return true;
        return false;
    }

    private bool IsDate(int day, int month, int year)
    {
        if (month is < 1 or > 12)
            return false;
        if (day < 1)
            return false;
        if (month is 1 or 3 or 5 or 7 or 8 or 10 or 12)
            return day <= 31;

        if (month is 4 or 6 or 9 or 11)
            return day <= 30;

        return (IsLeapYear(year) && day <= 29) || (day <= 28);
    }
    
    public Date(int day, int month, int year)
    {
        if (!IsDate(day, month, year))
            throw new ArgumentException();
        _day = day;
        _month = month;
        _year = year;
    }
}