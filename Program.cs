namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MoodAnalyzer Problem");

            //UC1
            HappySad happySad = new HappySad("happy mood");
            Console.WriteLine(happySad.AnalysingMood());

            //UC2
            //Console.WriteLine("mood anaylzer if invalid input");
            //InvalidMood invalidMood = new InvalidMood(" ");
            //Console.WriteLine(invalidMood.AnalysingMood());
        }
    }
}