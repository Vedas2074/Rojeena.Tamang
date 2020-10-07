using System;
class IterationStatement
{
    //pascal case: IterationStatement
    //camel case: iterationStatement
    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoops();

    }
     void LearnForLoops()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello World!");
        }

        int[] numbers = { 4, 5, 23, 45, 67, 12 };

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    void LearnWhileLoops()
    {
        string confirm = "Y";
        while (confirm == "Y")
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Want to print one more time?");
            confirm = Console.ReadLine();
        }

        string confirm1 = "Y";
        do
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Want to print one more time?");
            confirm1 = Console.ReadLine();
        } while (confirm1 == "Y");
    }

} 