using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_Cap2
{
    internal class Student
    {
        public string NameStudent;
        public int GradeStudent;     

        public Student()
        {
        }

        public Student(string nameStudent, int gradeStudent)
        {
            NameStudent = nameStudent;
            GradeStudent = gradeStudent;
        }

        public string GetStudent()
        {
            return "nome dello studente: " + NameStudent + ", voto: " + GradeStudent;
        }

        public string StudentWithGradeMax(List<Student> ListOfStudents)
        {
            string nameStudent = "";
            int maxGrade = ListOfStudents[0].GradeStudent;

            foreach (var student in ListOfStudents)
            {
                if (student.GradeStudent > maxGrade)
                {
                    maxGrade = student.GradeStudent;
                    nameStudent = student.NameStudent;
                }
            }
            return nameStudent;
        }
}
}