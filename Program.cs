using Dotnet_Cap2;

Console.WriteLine("creo 10 studenti con nomi e voto");
Student students = new Student();

Student student1 = new Student("Marco", 4);
Student student2 = new Student("Luca", 7);
Student student3 = new Student("Mario", 9);
Student student4 = new Student("GianMarco", 5);
Student student5 = new Student("Franco", 6);
Student student6 = new Student("Mauria", 2);
Student student7 = new Student("Alice", 10);
Student student8 = new Student("Francesca", 9);
Student student9 = new Student("Emanuele", 7);
Student student10 = new Student("Anna", 10);

List<Student> StudentList = new()
{
    student1, student2, student3, student4, student5,
    student6, student7, student8, student9, student10,
};

foreach(Student name in StudentList)
{
    Console.WriteLine(name.GetStudent());
}

double TotalGrade = 0;

foreach(Student student in StudentList)
{
    TotalGrade = (TotalGrade += student.GradeStudent) / StudentList.Count;
}

Console.WriteLine("\nla media totale è " + TotalGrade);

Console.Write("\nlo studente con il voto più alto è: ");

string NameStudent = students.StudentWithGradeMax(StudentList);
Console.WriteLine( NameStudent);



Console.WriteLine("\nsto stampando i nomi delgi studenti:");

List<string> nameStu = students.PrintNameStudent(StudentList);

foreach(string i in nameStu)
{
    Console.WriteLine(i);
}