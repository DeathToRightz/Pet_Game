//////////////////////////////////////////////
//Assignment/Lab/Project: Virtual Pet Game
//Name: Logan Cordova
//Section: SGD.213.2172
//Instructor: Professor Sowers
//Date: 02/26/2024
/////////////////////////////////////////////
public class Pet 
{
    //All the values needed for the Pet class
    private string _name;
    private int _hunger;
    private int _boredeom;
    private int _energy;

    public Pet()
    {
        //When a Pet object the name is blank for the player to fill and the starting stats are set to 100
        _name = string.Empty; ;
        _hunger = 100;
        _boredeom = 100;
        _energy = 100;
    }
    
    //Method gets and sets name 
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
    //Method gets and sets hunger level
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
    //Method gets and sets bored level
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
    //Method gets and sets energy level
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
    //Increase hunger level
    public int Eat( )
    {
        return _hunger += 10;
    }
    //Increase bored level, makes more sense in game
    public int Play()
    {
        return _boredeom += 10;
    }
    //Increase energy level
    public int Rest()
    {
        return _energy += 10;
    }
}
