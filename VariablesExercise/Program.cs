namespace VariablesExercise;

class Program
{
    static void Main(string[] args)
    {
        string name = "John";// declaring and initalizeing my variables
        int age = 34;
        char A = 'A';
        bool Tr = true;
        double payment = 16.50;
        decimal tax = 0.5m;

        Console.WriteLine($"{name} is {age}.\n" +
        $" {name} choose to order burger letter {A} for {payment}.\n" +
        $" It's {Tr}, {name} had to pay {tax} percent for taxes.");// string interpolation to display my variables


        string name1 = "Branden";
        int age1 = 3;
        char b = 'B';
        bool day = false;
        double weight = 25.86;
        decimal tax1 = 0.8m;

        Console.WriteLine($"{name1} turned {age1}.\n" +
        $"{name1} was marked {b} for boy at birth and it's {day} that he was born on the 5th.\n" +
        $"{name1} weigth after some time was {weight} and his car seat was expensive i felt like it was an {tax1} percent tax on his car seat.");
     // my additons to retry what was done before







    }
}

