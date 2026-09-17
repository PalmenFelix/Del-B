class Course
{
    public string? Name;
    public int MaxSeats;
    public List<Student> Students = new List<Student>();


    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        if (Students.Count < MaxSeats)
        {
            Students.Add(student);
            student.Courses.Add(this);
        }
        else
        {
            Console.WriteLine("Course is full");
        }
    }  

    public void Remove(Student student)
    {
        Students.Remove(student);
        student.Courses.Remove(this);
    }    

    public void RollCall()
    {
        Console.WriteLine("Course: " + Name);

        foreach (Student student in Students)
        {
        Console.WriteLine(student + " is here");
        }
    }

    public override string ToString()
    {
        return Name + " (" + Students.Count + "/" + MaxSeats + " spots)";
    }
}