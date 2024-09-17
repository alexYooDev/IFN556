internal class Program
{
    private static void Main(string[] args)
    {

        int numBooks, daysOverdue;

        Console.Write("Please enter the number of the books you have checked out: ");
        numBooks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the book's overdue dates: ");
        daysOverdue = Convert.ToInt32(Console.ReadLine());

        double overdueFine = CalculateFines(numBooks, daysOverdue);

        Console.WriteLine("The total overdue fine is {0:C}: ", overdueFine);
        
    }

    public static double CalculateFines(int books, int days)
    {
        const double BASE_RATE = 0.1;
        const double OVER_SEVEN_DATE = 0.2;
        const int THRESHOLD = 7;

        double fine;

        if (days <= THRESHOLD)
        {
            fine = BASE_RATE * books * days;
            return fine;
        } 


        int afterSevenDays = days - THRESHOLD;

        Console.WriteLine(BASE_RATE * THRESHOLD * books);
        Console.WriteLine(OVER_SEVEN_DATE * afterSevenDays * books);

        fine = (BASE_RATE * THRESHOLD * books) + (OVER_SEVEN_DATE * afterSevenDays * books);

        return fine;

    }
}