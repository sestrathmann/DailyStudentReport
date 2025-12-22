class Program
{
    private static void Main()
    {
        Console.WriteLine("                        T H E   T E C H   A C A D E M Y");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hi, " + name);
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine(course + ". That sounds fun!");
        Console.WriteLine("What page number?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wow! You've come so far! You're on page "+pageNumber+"!");
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());
        
        if (needsHelp)
        {
            Console.WriteLine("Don't worry, help is on the way!");
        }
        else
        {
            Console.WriteLine("Great! Keep up the good work!");
        }

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();
        Console.WriteLine("Thank you for sharing: " + positiveExperiences);
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("Thank you for your feedback: " + feedback);
        Console.WriteLine("How many hours did you study today?");
        float studyHours = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Wow! " + studyHours + " hours is impressive!");
        Console.WriteLine("Thank you for your answers, " + name + ". An Instructor will respond to this shortly. Have a great day!");
        Console.ReadKey();

    }
}