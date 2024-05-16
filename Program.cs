namespace Assignment2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.StudentId = 1;
            myStudent.StudentFname = "Josh";
            myStudent.StudentLname = "Reed";
            myStudent.StudentGrade = 'A';
            Console.WriteLine("StudentId is: " + myStudent.StudentId);
            Console.WriteLine("Student first name is: " + myStudent.StudentFname);
            Console.WriteLine("Student last name is: " + myStudent.StudentLname);
            Console.WriteLine("Student grade is: " + myStudent.StudentGrade);
        }



        public class Student
        {
            private int _studentId;
            private string _studentFname;
            private string _studentLname;
            private char _studentGrade;

            public int StudentId
            {
                get { return _studentId; }
                set { _studentId = value; }
            }
            public string StudentFname
            {
                get { return _studentFname; }
                set { _studentFname = value; }
            }
            public string StudentLname
            {
                get { return _studentLname; }
                set { _studentLname = value; }
            }
            public char StudentGrade
            {
                get { return _studentGrade; }
                set { _studentGrade = value; }
            }
        }

    }
}
