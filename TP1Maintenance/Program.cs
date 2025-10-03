using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Members;
using Helper;

public class Program
{
    static public List<Student> Studentss = new List<Student>(); // nom temporaire pour éviter les conflits avec la liste dans Student.cs
    static public List<Teacher> Teacherss = new List<Teacher>(); // nom temporaire pour éviter les conflits avec la liste dans Teacher.cs
    static public Principal Principal = new Principal(name: "", address: "", phoneNumber: 0);  // temporaire avant de regler les autres problemes
    static public Receptionist Receptionist = new Receptionist(name: "", address: "", phoneNumber: 0);  // temporaire avant de regler les autres problemes

    enum SchoolMemberType
    {
        typePrincipal = 1,
        typeTeacher,
        typeStudent,
        typeReceptionist
    }

    public static SchoolMember AcceptAttributes(string name, string address, int phoneNumber)
    {
        SchoolMember member = new SchoolMember(name, address, phoneNumber);
        member.Name = ConsoleHelper.AskInfoInput("Enter name: ");
        member.Address = ConsoleHelper.AskInfoInput("Enter address: ");
        member.PhoneNumber = ConsoleHelper.AskNumberInput("Enter phone number: ");

        return member;
    }

    private static int AcceptChoices()
    {
        return ConsoleHelper.AskNumberInput("\n1. Add\n2. Display\n3. Pay\n4. Raise Complaint\n5. Student Performance\nPlease enter the member type: ");
    }

    private static int AcceptMemberType()
    {
        int x = ConsoleHelper.AskNumberInput("\n1. Principal\n2. Teacher\n3. Student\n4. Receptionist\nPlease enter the member type: ");
        return Enum.IsDefined(typeof(SchoolMemberType), x) ? x : -1;
    }

    public static void AddPrincpal(string name, string address, int phoneNumber)
    {
        SchoolMember member = AcceptAttributes(name, address, phoneNumber);
        Principal.Name = member.Name;
        Principal.Address = member.Address;
        Principal.PhoneNumber = member.PhoneNumber;
    }

    private static void AddStudent(string name, string address, int phoneNumber)
    {
        SchoolMember member = AcceptAttributes(name, address, phoneNumber);
        Student newStudent = new Student(member.Name, member.Address, member.PhoneNumber);
        newStudent.Grade = ConsoleHelper.AskNumberInput("Enter grade: ");

        Studentss.Add(newStudent);
    }

    private static void AddTeacher(string name, string address, int phoneNumber)
    {
        SchoolMember member = AcceptAttributes(name, address, phoneNumber);
        Teacher newTeacher = new Teacher(member.Name, member.Address, member.PhoneNumber);
        newTeacher.Subject = ConsoleHelper.AskInfoInput("Enter subject: ");

        Teacherss.Add(newTeacher);
    }

    public static void Add(string name, string address, int phoneNumber)
    {
        Console.WriteLine("\nPlease note that the Principal/Receptionist details cannot be added or modified now.");
        int memberType = AcceptMemberType();

        switch (memberType)
        {
            case 2:
                AddTeacher(name, address, phoneNumber);
                break;
            case 3:
                AddStudent(name, address, phoneNumber);
                break;
            default:
                Console.WriteLine("Invalid input. Terminating operation.");
                break;
        }
    }

    public static void Pay()
    {
        Console.WriteLine("\nPlease note that the students cannot be paid.");
        int memberType = AcceptMemberType();

        Console.WriteLine("\nPayments in progress...");

        switch (memberType)
        {
            case 1:
                Principal.Pay();
                break;
            case 2:
                List<Task> payments = new List<Task>();

                foreach (Teacher teacher in Teacherss)
                {
                    Task payment = new Task(teacher.Pay);
                    payments.Add(payment);
                    payment.Start();
                }

                Task.WaitAll(payments.ToArray());

                break;
            case 4:
                Receptionist.Pay();
                break;
            default:
                Console.WriteLine("Invalid input. Terminating operation.");
                break;
        }

        Console.WriteLine("Payments completed.\n");
    }

    public static void RaiseComplaint()
    {
        Receptionist.HandleComplaint();
    }

    private static void HandleComplaintRaised(object sender, Complaint complaint)
    {
        Console.WriteLine("\nThis is a confirmation that we received your complaint. The details are as follows:");
        Console.WriteLine($"---------\nComplaint Time: {complaint.ComplaintTime.ToLongDateString()}, {complaint.ComplaintTime.ToLongTimeString()}");
        Console.WriteLine($"Complaint Raised: {complaint.ComplaintRaised}\n---------");
    }

    private static async Task ShowPerformance()
    {
        double average = await Task.Run(() => Student.CalculateAverageGrade(Studentss));
        Console.WriteLine($"The student average performance is: {average}");
    }

    private static void AddData()
    {
        Receptionist = new Receptionist("Receptionist", "address", 123);
        Receptionist.ComplaintRaised += HandleComplaintRaised;

        Principal = new Principal("Principal", "address", 123);

        for (int i = 0; i < 10; i++)
        {
            Studentss.Add(new Student(i.ToString(), i.ToString(), i, i));
            Teacherss.Add(new Teacher(i.ToString(), i.ToString(), i));
        }
    }

    public static async Task Main(string[] args)
    {
        // Just for manual testing purposes.
        AddData();

        Console.WriteLine("-------------- Welcome ---------------\n");

        //Console.WriteLine("Please enter the Princpals information.");
        //AddPrincpal();

        bool flag = true;
        while (flag)
        {

            int choice = AcceptChoices();
            switch (choice)
            {
                case 1:
                    Add(name: "name", address: "address", phoneNumber: 123456); // temporaire avant de regler les autres problemes
                    break;
                case 2:
                    //Display();
                    break;
                case 3:
                    Pay();
                    break;
                case 4:
                    RaiseComplaint();
                    break;
                case 5:
                    await ShowPerformance();
                    break;
                default:
                    flag = false;
                    break;
            }
        }

        Console.WriteLine("\n-------------- Bye --------------");
    }
}

