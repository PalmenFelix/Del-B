class Student
{
    public string? Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        Courses.Add(course);
    }

    public void Leave(Course course)
    {
        Courses.Remove(course);
    }

    Schedule()

    ToString()
}
