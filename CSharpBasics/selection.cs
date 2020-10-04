using System;

class SelectionStatement
{
    public void LearnIfElse()

    {
        // Console.WriteLine("What is your name : ");
        // string name = Console.ReadLine();
        // Console.WriteLine("Please provide your age :");
        // string ageString = Console.ReadLine();
        // byte age = byte.Parse(ageString);
        // if (age >=60) 
        // {
        //     Console.WriteLine("Your age is "+ age + ", so you can apply for your vatta.");
        // }  
        // else if (age <60 && age >=25) 
        // {
        //     Console.WriteLine("Your age is "+ age + ", so you are said to be Adult.");
        // }
        // else if (age <25 && age >=12) 
        // {
        //     Console.WriteLine("Your age is "+ age + ", so you are said to be Teenager.");
        // }
        
        // else Console.WriteLine("You are still child.");




        Console.WriteLine("Enter your hobby:");
        string hobby = Console.ReadLine();

        switch(hobby)
        {
            case "Gaming": Console.WriteLine("You have good future.");
            break;
            case "Cricket": Console.WriteLine("You will become Sachin.");
            break;
            case "Football": Console.WriteLine("You will become Pele.");
            break;
            
            default: Console.WriteLine("Your future is in danger.");
            break;
        }
    }
}