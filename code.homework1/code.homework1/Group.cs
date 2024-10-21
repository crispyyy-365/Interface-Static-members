using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace code.homework1
{
    internal class Group 
    {
        public static Group[] groups = new Group[0];
        public static int GroupCount { get; set; } = 0;
        public static int GroupId { get; set; } 
        public static string GroupName { get; set; }

        public Student[] students = new Student[0];

        public Group(string groupName)
        {
            GroupName = groupName;

            GroupCount++;
            GroupId = GroupCount;
        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"Goup Id : {GroupId} , Group Name : {GroupName} , Number of the students in the group : {students.Length}");
        }
        public string GetStudentID(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if(id == students[i]._id)
                {
                    return students[i].Name;
                }
            }
            return null;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public void Search(string name , string surname)
        {
            for(int i = 0;i < students.Length;i++)
            {
                if (name == students[i].Name && surname == students[i].Surname)
                {
                    Console.WriteLine($"Id : {students[i]._id} , Name : {students[i].Name} , Surname : {students[i].Surname} , Code E-Mail : {students[i].CodeEmail}");
                    break;
                }
                else
                {
                    Console.WriteLine("the student does not exist.");
                    break;
                }
            }
        }
        public void RemoveStudent(int id)
        {
            for( int i = 0; i < students.Length; i++)
            {
                if(students[i]._id == id)
                {
                    for (int j = i; j < students.Length; j++) 
                    {
                        students[i] = students[j];
                    }
                    Array.Resize(ref students, students.Length - 1);
                }
                else
                {
                    Console.WriteLine("the student does not exist.");
                    break;
                }
            }
        }
        public void ShowStudents()
        {
            Console.WriteLine("Students : ");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
        public static void ShowAllGroups()
        {
            for(int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"Goup Id : {GroupId} , Group Name : {GroupName}");
            }
        }
        public static void AddGroup(Group group)
        {
            Array.Resize(ref groups, groups.Length + 1);
            groups[groups.Length - 1] = group;
            
        }
        public static void RemoveGroup(int id)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                if (GroupId == id)
                {
                    for (int j = i; j < groups.Length - 1; j++)
                    {
                        groups[i] = groups[j];
                    }
                    Array.Resize(ref groups, groups.Length - 1);
                }
                else
                {
                    Console.WriteLine("the group does not exist.");
                }
            }
        }
    }
}
