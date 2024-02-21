public class Pet 
{
    private string _name;
    private int _hunger;
    private int _boredeom;
    private int _energy;

    public Pet()
    {
        _name = string.Empty; ;
        _hunger = 100;
        _boredeom = 100;
        _energy = 100;
    }
    

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public int Hunger
    {
        get
        {
            return _hunger;
        }
        set
        {
            _hunger = value ;
        }
    }

    public int Bordeom
    {
        get
        {
           return _boredeom;
        }
        set
        {
            _boredeom= value;
        }
    }

    public int Energy
    {
        get
        {
            return _energy;
        }
        set
        {
            _energy = value;
        }
    }
    
    public int Eat( )
    {
        return _hunger += 10;
    }
    public int Play()
    {
        return _boredeom += 10;
    }
    public int Rest()
    {
        return _energy += 10;
    }
}
