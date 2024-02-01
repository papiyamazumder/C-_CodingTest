//internal class Program        // STUDENT CLASS 
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Enter student name: ");
//        string inputName = Console.ReadLine().ToUpper();

//        List<Student> students = new List<Student>
//            {
//                new Student(111, "A", "C#"),
//                new Student(112, "B", "ASP.NET"),
//                new Student(97, "C", "C#"),
//                new Student(87, "D", "C#")
//            };

//        Student foundStudent = students.Find(student => student.Name == inputName);

//        if (foundStudent != null)
//        {
//            Console.Write("Enter Amount Paid: ");
//            var amt = Convert.ToInt32(Console.ReadLine().ToUpper());

//            foundStudent.Payment(amt);
//            Console.WriteLine("");
//            Console.WriteLine("Student Details: ");
//            foundStudent.Print();
//        }
//        else
//        {
//            Console.WriteLine($"Student with name {inputName} not found in the list.");
//        }
//    }
//}

//public class Student
//{
//    public int RollNo { get; }
//    public string Name { get; }
//    public string Course { get; }
//    public int FeePaid { get; set; }
//    public int DueAmount => TotalFee - FeePaid; 
//    public int TotalFee { get; set; }

//    private const int FeeForCSharp = 2000;
//    private const int FeeForAspNet = 3000;

//    public Student (int rollNo, string name, string course)
//    {
//        RollNo = rollNo;
//        Name = name;
//        Course = course;

//        FeePaid = 0;

//        if (Course == "C#")
//        {
//            TotalFee = FeeForCSharp;
//        }
//        else if (Course == "ASP.NET")
//        {
//            TotalFee = FeeForAspNet;
//        }
//        else
//        {
//            TotalFee = 0;
//        }
//        // OR
//        //TotalFee = (course == "C#") ? FeeForCSharp : (course == "ASP.NET") ? FeeForAspNet : 0;

//        //DueAmount = TotalFee - FeePaid;
//    }

//    public void Payment(int amount)
//    {
//        if (amount < 0)
//        {
//            Console.WriteLine("Invalid payment amount. Please enter the amount of course fee paid.");
//        }
//        else
//        {
//            FeePaid = FeePaid + amount;
//            Console.WriteLine($"Payment of {amount} made successfully. Fee Due for {Course} course : {DueAmount} ");
//        }
//    }

//    public void Print()
//    {
//        Console.WriteLine($"Roll No: {RollNo}");
//        Console.WriteLine($"Name: {Name}");
//        Console.WriteLine($"Course: {Course}");
//        Console.WriteLine($"Fee Paid: {FeePaid}");
//        Console.WriteLine($"Due Amount: {DueAmount}");
//        Console.WriteLine($"Total Fee: {TotalFee}");
//    }

//}