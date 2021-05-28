using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        /*
        Make a program that contains a list of students going on a weekend field trip<Project Sdk="Microsoft.NET.Sdk">
        Students should have
            - first name
            - last name
            - bus seat number 
            - group number
                - Teacher/Chaperone 
                - room number
            - may have allergies

        */
        static void addStudent(ref List<FieldTripStudent> lst )
        {
            // Create class object
            var newStudent = new FieldTripStudent();
            // Get student first and last name
            Console.Write("\nEnter first name: ");
            newStudent.firstName = Console.ReadLine().ToString();
            Console.Write("Enter last name: ");
            newStudent.lastName = Console.ReadLine().ToString();
            // Seat number for bus
            Console.Write("Enter bus seat number: ");
            newStudent.seatNumber = int.Parse(Console.ReadLine());
            // Group number
            Console.Write("Enter group number: ");
            newStudent.group.number = int.Parse(Console.ReadLine());
            // Hotel Room Number
            Console.Write("Enter full name of group chaparone: ");
            newStudent.group.guideName = Console.ReadLine().ToString();
            // 
            Console.Write("Enter hotel room number: ");
            newStudent.group.roomNumber = int.Parse(Console.ReadLine());
            
            lst.Add(newStudent);

            return;
        }
        static void ReadList(List<FieldTripStudent> lst )
        {
            foreach(FieldTripStudent student in lst)
            {
                Console.WriteLine("\nStudent Name: {0} {1}", student.firstName, 
                    student.lastName);
                Console.WriteLine("Seat Number: {0}", student.seatNumber);
                Console.WriteLine("Group Number: {0}", student.group.number);
                Console.WriteLine("Guide Number: {0}", student.group.guideName);
                Console.WriteLine("Hotel Room Number: {0}", student.group.roomNumber);
                
            }
        }
        static void Main(string[] args)
        {
            bool keepGoing = true;
            var fieldTrip = new List<FieldTripStudent>();
            do
            {
                Console.Write("Do you wish to add a new student to the field trip list?\nEnter Yes or No: ");
                var selection = Console.ReadLine();
                if(selection.ToString().ToLower() == "no")
                {
                    keepGoing = false;
                }
                else if(selection.ToString().ToLower() == "yes")
                {
                    addStudent(lst: ref fieldTrip);
                }
                else
                {
                    Console.WriteLine("\nInvalid selection!");
                    
                }

            }while(keepGoing == true);
            ReadList(fieldTrip);
    
        }
    }

    
}

class FieldTripStudent
{
    public string firstName;
    public string lastName;
    public int seatNumber;
    public Group group = new Group(); 

}

class Group
{
    public int number;
    public string guideName;
    public int roomNumber;
}
