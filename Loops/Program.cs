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
            newStudent.firstName = Console.Read().ToString();
            Console.Write("\nEnter last name: ");
            newStudent.lastName = Console.Read().ToString();
            // Seat number for bus
            Console.Write("\nEnter bus seat number: ");
            newStudent.seatNumber = Console.Read();
            // Group number
            Console.Write("\nEnter group number: ");
            newStudent.group.number = console.Read();
            // Hotel Room Number
            Console.Write("\nEnter full name of group chaparone: ");
            newStudent.group.guideName = console.Read();
            // 
            Console.Write("\nEnter hotel room number: ");
            newStudent.group.roomNumber = console.Read();
            
            lst.Add(newStudent);

            return;
        }
        static void Main(string[] args)
        {
            bool keepGoing = true;
            var fieldTrip = new List<FieldTripStudent>();
            do
            {
                Console.Write("Do you wish to add a new student to the field trip list?\nEnter Yes or No: ");
                var selection = Console.Read();
                if(selection.ToString().ToLower() == "no")
                {
                    keepGoing = false;
                }
                else if(selection.ToString().ToLower() == "yes")
                {
                    addStudent();
                }
                else
                {
                    console.WriteLine("\nInvalid selection!");
                    
                }

            }while(keepGoing == true);
    
        }
    }

    
}

class FieldTripStudent
{
    public string firstName;
    public string lastName;
    public int seatNumber;
    public Group group; 

}

struct Group
{
    int number;
    string guideName;
    int roomNumber;
}
