using System;
using System.Collections.Generic;

namespace LList
{
    class Program
    {
        ///
        /// <summary>
        /// take a lists of grades and a list of student names from a single course 
        /// make a linked list.
        /// </summary>
        static void Main(string[] args)
        {
            // List of CS 348 students
            var studentNames = new List<string> {"Amy", "Billy", "Carl"};
            // List of grades for CS 348
            var studentGrades = new List<int> {85, 74, 89};

            var course = new LinkedList<CS_348>();

            for(var i = 0; i < studentNames.Count; i++)
            {
                var student = new CS_348(str: studentNames[i], num: studentGrades[i]);
                course.AddLast(student);
            }
            Console.WriteLine("Number of students: {0}", course.Count);
            foreach(var pupil in course)
            {
                pupil.Read();
            }
        } 
    }
}

class CS_348
{
    private string name = "";
    private int grade = 0;
    public CS_348(string str, int num)
    {
        name = str;
        grade = num;
    }
    public CS_348(int num)
    {
        grade = num;
    }
    public CS_348(string str)
    {
        name = str;
    }
    public void Read()
    {
        Console.WriteLine("Name: {0}\nGrade: {1}", name, grade);
        
    }
}