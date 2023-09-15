using System;

namespace StudentProject.Models
{
    public enum SchoolClassType { ClassA, ClassB, ClassC}

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public string EducationLevel { get; set; }
    }
}
