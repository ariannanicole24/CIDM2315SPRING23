using System;

class Professor
{
    public string profName;
    public string classteach;
    private double salary;

    public void givenSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    public string studentName;
    public string ClassEnroll;
    private double studentGrade;

    public void SetStudentGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    public double GetStudentGrade()
    {
        return studentGrade();
    }
}

class Program
{
    static void Main()
    {
        Professor pf1 = new Professor();
        pf1.profName= "Alice";
        pf1.classTeach = "Java";
        pf1.SetSalary(9000.0);

        Professor pf2 = new Professor();
        pf2.profName = "Bob";
        pf2.classTeach = "Math";
        pf2.SetSalary(8000.0);

        Student st1 = new Student();
        st1.studentName = "Lisa";
        st1.ClassEnroll = "Java";
        st1.SetStudentGrade(90.0);

        Student st2 = new Student();
        st2.studentName = "Tom";
        st2.ClassEnroll = "Math";
        st2.SetStudentGrade(80.0);

        Console.WriteLine("Professor " + pf1.profName + " teaches " + pf1.classTeach + ", and the salary is: " + pf1.GetSalary());

        Console.WriteLine("Professor " + pf2.profName + " teaches " + pf2.classteach + ", and the salary is; " + pf2.GetSalary());

        Console.WriteLine("Student " + st1.studentName + " enrolls " + st1.ClassEnroll + ", and the grade is: " + st2.GetStudentGrade());

        Console.WriteLine("Student " + st2.studentName + " enrolls " + st2.ClassEnroll + ", and the grade is:: " + st2.GetStudentGrade ());

        Console.WriteLine("The salary difference between " + pf1.profName + " and " + pf2.profName + " is, " + (pf1.GetSalary() - pf2.GetSalary()));

        Console.WriteLine("The total grade of " + " is; " + (st1.GetStudentGrade() + st2.GetStudentGrade())); 
    }
}