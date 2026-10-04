namespace CollectionsAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1: Student Grade Manager
            Console.WriteLine("---------Grade Manager-----------");
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


            #region Exercise 2: Leaderboard
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("-----Leader Board----");
            // 1-2 Create and print
            SortedDictionary<int, string> scores = new SortedDictionary<int, string>()
            {
                {500 ,"Ahmed"},
                {200 ,"Sara"},
                {800 ,"Ali"},
                {350 ,"Mona"}
            };
            Printer.PrintCollection("Scores", scores);

            // 3 Access first key and value
            Console.WriteLine($"Firts Key : {scores.Keys.First()}");
            Console.WriteLine($"First Vlaue : {scores.Values.First()}");

            // 4 check for 500
            Console.WriteLine($"Check for score 500 : {scores.ContainsKey(500)}");

            // 5 get player with 999
            if (scores.TryGetValue(999, out string player))
            {
                Console.WriteLine($"Player with score 999 : {player}");
            }
            else
            {
                Console.WriteLine("Player with score 999 not found.");
            }


            // 6 Remove player with score 200
            scores.Remove(200);
            Printer.PrintCollection("Scores after removing score 200", scores);
            #endregion


            #region Exercise 3: Phone Book
            Console.WriteLine();
            Console.WriteLine("===================");
            Console.WriteLine("----Phone Book----");
            // 1 Create collection
            Dictionary<string, string> contacts = new Dictionary<string, string>()
            {
                {"Yousif" , "01064079131" },
                {"Malek", "01001146667"},
                {"Ahmed", "01078534121" },
                {"Mohamed", "01248723878" }
            };

            // 2 Add new contact
            contacts["Yassin"] = "01064079141";

            Printer.PrintCollection("Contacts", contacts);


            // 3 Adding duplicateb using Add
            try
            {
                contacts.Add("Ahmed", "01078534121");

            }
            catch
            {
                Console.WriteLine("Contact Already Exists");
            }


            // 4 Adding duplicate using TryAdd
            Console.WriteLine($"Contact Added? : {contacts.TryAdd("Ahmed", "01078534121")}");


            // 5 search for a contact !Exists
            Console.WriteLine(contacts.ContainsKey("Rola"));


            // 6 Fallback
            Console.WriteLine(contacts.GetValueOrDefault("Yousif", "Not Found"));
            Console.WriteLine(contacts.GetValueOrDefault("Rola", "Not Found"));

            // 7 print 

            Console.Write(string.Join(", ", contacts.Keys));
            Console.WriteLine();
            Console.Write(string.Join(", ", contacts.Values)); 
            #endregion
        }
    }
}
