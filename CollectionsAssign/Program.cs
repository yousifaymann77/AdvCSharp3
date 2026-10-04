namespace CollectionsAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1: Student Grade Manager
            // 1 - 2 Create list and print the first and last element
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            Printer.PrintCollection("Grades", grades);
            Console.WriteLine(grades[0]);
            Console.WriteLine(grades[^1]);

            // 3 Sort the list
            grades.Sort();
            Printer.PrintCollection("Sorted Grades", grades);

            // 4 Find the first grade above 90
            int high = grades.Find(x => x > 90);
            Console.WriteLine($"First High Grade Above 90 : {high}");

            // 5 Find all grades below 70
            List<int> failingGrades = grades.FindAll(x => x < 70);
            Printer.PrintCollection("Failing Grades", failingGrades);

            // 6 Remove all grades below 70
            grades.RemoveAll(x => x < 70);
            Printer.PrintCollection("Remaining Grades", grades);

            // 7 Check if the list contains a grade of 100
            Console.WriteLine(grades.Exists(x => x == 100));

            // 8 Convert the list of grades to a list of strings
            List<string> strings = grades.ConvertAll(x => $"Grade : {x}");
            Printer.PrintCollection("Numbers String ", strings); 
            #endregion



        }
    }
}
