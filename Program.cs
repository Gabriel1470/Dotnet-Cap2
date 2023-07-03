using Dotnet_Cap2;

Console.WriteLine("creo 10 studenti con nomi e voto");
List<Student> students = new List<Student>()
{
    new Student { Name = "Marco", Grade=4},
new Student{ Name = "Luca", Grade=4} ,
new Student{ Name = "Mario", Grade=4} ,
new Student{ Name = "GianMarco", Grade=4}, 
new Student{ Name = "Franco", Grade=4}, 
new Student{ Name = "Mauria", Grade=4}, 
new Student{ Name = "Alice", Grade=4}, 
new Student{ Name = "Francesca", Grade=4}, 
new Student{ Name = "Emanuele", Grade=4}, 
new Student{ Name = "Anna", Grade=4} 
};
 int gradeMax = 0;
 int somma = 0;
 int nom = 0;
 double res = 0;


foreach(Student student in students)
{
    if(student.gradeMax > gradeMax)
    {
        gradeMax = student.gradeMax;
    }
    somma += student.grade;
    nom++;
}

res = ((double) somma) / nom;

Console.WriteLine($"La Media e :{res}");


Console.Write("\nlo studente con il voto più alto è: ");

foreach(Student student in students)
{
    if(student.Grade == gradeMax)
    {
        Console.WriteLine(student);
    }
}