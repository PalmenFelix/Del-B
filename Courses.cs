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

    Enroll(Student student)
    Remove(Student student)
    RollCall()
    ToString()  
}