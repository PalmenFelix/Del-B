class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        Courses.Add(course);
        course.Students.Add(this);
    }

    public void Leave(Course course)
    {
        Courses.Remove(course);
        course.Students.Remove(this);
    }

    public void Schedule()
    {
        foreach (Course course in Courses)
        {
            Console.WriteLine("Studenten " + this + " går kursen " + course);
        }
    }

    public override string ToString()
    {
        return Name;
    }
}
