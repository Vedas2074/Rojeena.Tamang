using System;
using System.Linq;

class Methods
{
    void PrintInfo()
    {
        Console.WriteLine("Printing Something.....");
        Multiply(23.5f,44.5f);
        Multiply(23.5f,44.5f,55.5f);

        Sum(1,2,3);
        Sum(44,55,66,77,88);

        Greet("Bipin","Mr.");
        Greet("Ishan"); 


        byte[] numbers = { 2, 4, 1, 125, 0, 5, 55};
        (byte Min , byte Max) result = FindMinMax(numbers);


        PrintSomething(name: "Bipin", age: 22, address: "Dang", isMale: true);
        
    }

    void PrintSomething(string message)
    {
        Console.WriteLine(message);
        
    }

    float Multiply(float firstNum, float secondNum)
    {
        float product = firstNum + secondNum ;
        return product;
    }

    float Multiply(float firstNum, float secondNum, float thirdNum)
    {
        float product = firstNum + secondNum + thirdNum ;
        return product;
    }


    double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach(double num in numbers)
        {
            sum = sum + num;            
        }
        return sum;
    }



    //Optional Arguments

    string Greet(string name , string prefix="Dear")
    {
        string fullName = $"{prefix}, {name}";   //prefix + "," + name; //string interpolation
        return fullName;
    }

    //Returning multiple values: using tuples

    (byte, byte) FindMinMax(byte[] numbers)
    {
        byte max = numbers.Max();
        byte min = numbers.Min();

        return (min,max);
    }


    void PrintSomething(string name, string address, byte age, bool isMale)
    {
        Console.WriteLine($"{name}, [{age}], {address}, {isMale}");
        
    }

    float Substract(float firstNum, float secondNum) => firstNum - secondNum ; //expression body method
    


}