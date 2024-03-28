using System;

public class Converter
{
    public void Logger()
    {
        float userInputNumber;
        float userMethodChoise;
        Console.WriteLine("Enter Your Number");
        var num = Console.ReadLine();
        userInputNumber = float.Parse(num);
        Console.WriteLine("if is it Feet press 1 , for Inch press 2 :");
        var unit = Console.ReadLine();
        userMethodChoise = float.Parse(unit);
        var result = CheckInput(userMethodChoise, userInputNumber);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    private static float CheckInput(float input, float value)
    {
        if (input == 1)
        {
            return FeetToCM(value);
        }
        else if (input == 2)
        {
            return InchToFeet(value);
        }

        return 0;
    }

    private static float FeetToCM(float feet)
    {
        float CM = feet * InchToFeet(12);
        return CM;
    }

    private static float InchToFeet(float inch)
    {
        float CM = inch * 2.54f;
        return CM;
    }

}