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

    abstract protected void descibe();


    public virtual void use()
    {
        bool therIs = true;
    }
}


public class Hammer :Tools
{
    private int _amount;



    public Hammer(int amount ,string name,int weight):base (name,weight)
    {
        this._amount = amount;    

    }

    public void descibe()
    {
        Console.WriteLine("this tool is may drive nails, etc !! ");
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



public class Wrench : Tools
{
    private int _amount;



    public Wrench(int amount, string name, int weight) : base(name, weight)
    {
        this._amount = amount;

    }

    public void descibe()
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
