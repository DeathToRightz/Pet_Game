public class Pet 
{
    private string _name;
    private int _hunger;
    private int _boredeom;
    private int _energy;

    public Pet()
    {
        _name = string.Empty; ;
        _hunger = 0;
        _boredeom = 0;
        _energy = 0;
    }
    public Pet( string name)
    {
        _name = name;
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
            _hunger = value;
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

    public int energy
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
}
