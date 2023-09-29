using System;




class Program
{
    public struct Student
    {
        public string Name;
        public string Initials;
        public int GroupNumber;
        public float[] GPA;

        public Student(string name, string initials, int groupNumber, float[] gpa)
        {
            Name = name;
            Initials = initials;
            GroupNumber = groupNumber;
            GPA = gpa;
        }
    }
      public static void HighGradesStuds(Student[] students)
    {
        foreach(var student in students)
        {
            bool high = true;
            foreach(var grade in student.GPA)
            {
                if(grade < 4)
                {
                    high = false;
                    break;
                }
                if (high)
                {
                    Console.WriteLine($"Умник {student.Name}, Из группы {student.GroupNumber} ");
                }
            }
        }
    }

    public static void Main()
    {
        Student[] students = new Student[10];
        students[0] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 5.0f });
        students[1] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 5.0f });
        students[2] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 4.0f });
        students[3] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 5.0f });
        students[4] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 3.0f });
        students[5] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 3.0f });
        students[6] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 3.0f });
        students[7] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 3.0f });
        students[8] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 3.0f });
        students[9] = new Student("Zhursinbek Nurbolat", "ZNN", 2, new float[] { 3.0f });
        HighGradesStuds(students);
    }
}
