using System;
class MainApp
{
    static void Main()
    {
        CalculateClient minusClient = new CalculateClient(new Minus());
        Response.Write("Minus: " + minusClient.Calculate(7, 1).ToString());

        CalculateClient plusClient = new CalculateClient(new Plus());
        Response.Write("Plus: " + plusClient.Calculate(7, 1).ToString());
        // Wait for user  
        Console.ReadKey();
    }
}

public interface ICalculateInterface
{
    //define method  
    int Calculate(int value1, int value2);
}

class Minus : ICalculateInterface
{
    public int Calculate(int value1, int value2)
    {
        //define logic  
        return value1 - value2;
    }
}

class Plus : ICalculateInterface
{
    public int Calculate(int value1, int value2)
    {
        //define logic  
        return value1 + value2;
    }
}

class CalculateClient
{
    private ICalculateInterface calculateInterface;

    //Constructor: assigns strategy to interface  
    public CalculateClient(ICalculateInterface strategy)
    {
        calculateInterface = strategy;
    }

    //Executes the strategy  
    public int Calculate(int value1, int value2)
    {
        return calculateInterface.Calculate(value1, value2);
    }
}