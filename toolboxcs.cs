using System;

abstract public class Tools
{
    protected string name;
    protected int weight;


    public Tools(string name,int weight)
    {
        this.name = name;
        this.weight = weight;
    }

    abstract public void describe();


    public virtual void use()
    {
        bool therIs = false;
        Console.WriteLine("uiohuh");
    }
}


public class Hammer :Tools
{
    private int _amount;



    public Hammer(int amount ,string name,int weight):base (name,weight)
    {
        this._amount = amount;    

    }

    public override void describe()
    {
        Console.WriteLine("this tool is may drive nails, etc !! ");
    }

    public  void use()
    {
        if (_amount < 0)
        {
            Console.WriteLine("you can use it");
        }
        else { Console.WriteLine("its olradi used"); }
    }
}



public class Wrench : Tools
{
    private int _amount;



    public Wrench(int amount) : base("Wrench", 25)
    {
        this._amount = amount;

    }

    public override void describe()
    {
        Console.WriteLine("this tool is may unscrew screws !! ");
    }

    public override void use()
    {
        if (_amount < 0)
        {
            Console.WriteLine("you can use it");
        }
        else { Console.WriteLine("its olradi used"); }
    }
}




public class Drill : Tools
{
    private int _amount;



    public Drill(int amount, string name, int weight) : base(name, weight)
    {
        this._amount = amount;

    }

    public override void describe()
    {
        Console.WriteLine("this tool is may drill holes !! ");
    }

    public override void use()
    {
        if (_amount < 0)
        {   
            Console.WriteLine("you can use it");
        }
        else { Console.WriteLine("its olradi used"); }
    }
}

public class Saw : Tools
{
    private int _amount;



    public Saw(int amount, string name, int weight) : base(name, weight)
    {
        this._amount = amount;

    }

    public override void describe()
    {
        Console.WriteLine("this tool is may to saw !! ");
    }

    public override void use()
    {
        if (_amount < 0)
        {
            Console.WriteLine("you can use it");
        }
        else { Console.WriteLine("its olradi used"); }
    }
}


public class Screwdriver : Tools
{
    private int _amount;



    public Screwdriver(int amount) : base("Screwdriver",96)
    {
        this._amount = amount;

    }

    public override void describe()
    {
        Console.WriteLine("this tool is may Screwdriver !! ");
    }

    public override void use()
    {
        if (_amount < 0)
        {
            Console.WriteLine("you can use it");
        }
        else { Console.WriteLine("its olradi used"); }
    }
}


public class PipeCutter : Tools
{
    private int _amount;



    public PipeCutter(int amount, string name, int weight) : base(name, weight)
    {
        this._amount = amount;

    }

    public override void describe()
    {
        Console.WriteLine("this tool is may PipeCutter !! ");
    }

    public override void use()
    {
        if (_amount < 0)
        {
            Console.WriteLine("you can use it");
        }
        else { Console.WriteLine("its olradi used"); }
    }
}
