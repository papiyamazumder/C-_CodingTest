//using System;       // STUDENT AND PERSON

//class Person
//{
//    public string firstName;
//    public string lastName;
//    public int id;

//    public Person(string firstName, string lastName, int id)
//    {
//        this.firstName = firstName;
//        this.lastName = lastName;
//        this.id = id;  
//    }
//}

//class Student : Person
//{
//    public int[] testScores;

//    public Student(string firstName, string lastName, int id, int[] testScores) : base(firstName, lastName, id)
//    {
//        this.testScores = testScores;  
//    }

//    public char calculate()
//    {
//        //int sum = 0;
//        //foreach (var test in testScores)
//        //{
//        //    test += sum;
//        //}
//        // OR
//        int sum = testScores.Sum();  // Assuming you have a using directive for System.Linq
//        int average = sum / testScores.Length;
//        Console.WriteLine($"Average: {average}");

//        if (average >= 90 && average <= 100)
//        {
//            return 'O';
//        }
//        else if (average >= 80 && average < 90)
//        {
//            return 'E';
//        }
//        else if (average >= 70 && average < 80)
//        {
//            return 'A';
//        }
//        else if (average >= 55 && average < 70)
//        {
//            return 'P';
//        }
//        else if (average >= 40 && average < 55)
//        {
//            return 'D';
//        }
//        else if (average < 40 && average > 0)
//        {
//            return 'T';
//        }
//        else
//        {
//            return ' ';
//        }
//    }
//}

//class Solution
//{
//    static void Main()
//    {
//        //int[] testScores = { 100, 80 };
//        //Student s = new Student("Heraldo", "Memelli", 8135627, testScores);
//        //var grade = s.calculate();

//        //Console.WriteLine($"Name: {s.lastName}, {s.firstName}\nID: {s.id}");
//        //Console.WriteLine($"Grade: {grade}");

//        // OR taking user input:

//        Console.WriteLine("Enter firstname and last name: ");
//        var FN = Console.ReadLine().ToUpper();
//        var LN = Console.ReadLine().ToUpper();
//        Console.Write("Enter your ID: ");
//        var ID = Console.ReadLine();

//        if (FN.Length >= 1 && FN.Length <= 10 && LN.Length >= 1 && LN.Length <= 10 && ID.Length == 7)
//        {
//            Console.Write("Enter test scores (space-separated): ");
//            string scoresInput = Console.ReadLine();
//            int[] testScores = Array.ConvertAll(scoresInput.Split(' '), int.Parse);

//            Student s = new Student(FN, LN, int.Parse(ID), testScores);
//            Console.WriteLine("\nStudent Details: ");
//            Console.Write($"Name: {s.lastName}, {s.firstName}\nID: {s.id} \n");
//            string grade = s.calculate().ToString();
//            Console.Write($"Grade: {grade}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. First name and last name should be between 1 and 10 characters each, and ID should be 7 characters.");
//        }
//    }
//}
