using ConsoleApp44.Entities;

Student student1 = new Student("NURANE", "SADIGOVA", 21, 78);
Student student2 = new Student("Babek", "Elekberli", 25, 88);
Student student3 = new Student("Cahangir", "Cahangirov", 18, 94);
Student student4 = new Student("Hitler", "Adolf", 23, 69);


Group group = new Group(4, 10);
group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);
group.AddStudent(student4);

group.GroupInfo(); //AP101 

Group group1 = new Group(5, 10);
group1.AddStudent(student1);
group1.AddStudent(student2);
group1.AddStudent(student3);
group1.AddStudent(student4);
group1.SortbyPoint();
group1.GroupInfo(); //AP102 