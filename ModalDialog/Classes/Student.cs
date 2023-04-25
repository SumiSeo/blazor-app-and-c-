using System;
namespace ModalDialog.classes
{
	public class Student
	{
        public string StudentName { get;set; }
        public string StudentAge { get; set; }
        public string StudentSchool { get; set; }

        public Student(string name, string age, string school)
		{
			Console.WriteLine("new student information added");
			StudentName = name;
			StudentAge = age;
			StudentSchool = school;
		}
	}
}

