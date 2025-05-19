

using System;

public class Wrench2 : Tools
{
    private int _amount;



    public Wrench2(int amount) : base("Wrench", 25)
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




public class Wrench8 : Tools
{
    private int _amount;



    public Wrench8(int amount) : base("Wrench", 25)
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
