namespace ConsoleApp44.Entities
{
    public class Student
    {
        private static int _id;
        public int Id { get; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string name, string surname, int age, int point)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Id + " " + Name + " " + Surname + " " + Age + " " + Point);
        }
    }
}