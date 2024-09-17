internal class Program
{
    private static void Main(string[] args)
    {
        double averageGPA = 3.0;

        Console.Write("Please enter your GPA | ex) 3.2: ");
        double studentGPA = Convert.ToDouble(Console.ReadLine());

        string result = checkAdmission(averageGPA, studentGPA);

        Console.WriteLine(result);

    }

    public static string checkAdmission(double averageGPA, double GPA) 
    {
        bool mark1 = false;
        bool mark2 = false;

        const int lowScore = 60;
        const int highScore = 80;

        if (GPA >= averageGPA)
        {
            mark1 = true;
            Console.WriteLine($"Now enter your admission test score, according to your GPA:{GPA}, your admission score needs to be at least 60.");
        }
        else
        {
            Console.WriteLine($"Now enter your admission test score, according to your GPA:{GPA}, your admission score needs to be at least 80.");
        }

        int studentTestScore = Convert.ToInt32(Console.ReadLine());

        if (mark1 && studentTestScore >= lowScore)
        {
            mark2 = true;
        }

        if (mark1 == false && studentTestScore >= highScore)
        {
            mark2 = true;
        }

        if (mark1 && mark2)
        {
            return "Accept!";
        }

        return "Reject!";
    }
}