
using ConsoleApp44.PracticeException;

namespace ConsoleApp44.Entities;
           
public class Group
{
    private static int _groupid = 100;
    public int GroupId { get; }
    public string GroupNo;
    private List<Student> Students { get; set; }
    public int GroupMax { get; set; }
    public int GroupMin { get; set; }



    public Group(int groupmin, int groupmax)
    {
        _groupid++;
        GroupId = _groupid;
        GroupNo = $"AP{GroupId}";
        GroupMax = groupmax;
        GroupMin = groupmin;
        Students = new List<Student>();
    }

    public void GroupInfo()
    {
        Console.WriteLine($"Group No:{GroupNo},Students: {Students.Count}");
    }

    public void AddStudent(Student student)
    {
        {
            if (Students.Count >= GroupMax)
            {
                throw new LimitException("Sagird sayi limitdedir");
            }
            else
            {
                Students.Add(student);
            }
        }
    }

    public void GetStudent()
    {
        foreach (Student student in Students)
        {
            Console.WriteLine($"ID: {student.Id}, Name:{student.Name}, Surname: {student.Surname}, Age: {student.Age}, Point: {student.Point}");
        }
    }

    public void SortbyPoint()
    {
        Group sortedGroup = new Group(5, 10);

        foreach (Student student in Students)
        {
            Student studentCopy = new Student(student.Name, student.Surname, student.Age, student.Point);
            sortedGroup.AddStudent(studentCopy);
        }

        sortedGroup.Students.Sort((s1, s2) => s1.Point.CompareTo(s2.Point));

        sortedGroup.GetStudent();
    }
}