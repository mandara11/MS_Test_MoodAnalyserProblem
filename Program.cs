namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MoodAnalyzer Problem");

            HappySad happySad = new HappySad("i am in sad a mood");
            Console.WriteLine(happySad.AnalysingMood());
        }
    }
}