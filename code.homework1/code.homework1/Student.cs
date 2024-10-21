using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace code.homework1
{
    internal class Student : ICodeAcademy
    {
        public string CodeEmail { get; set; }
        public static int _count { get; set; } = 0;
        public int _id { get; set; }
        public string _name;
        public string _surname;
        public string Name
        {
            get { return _name; }
            set { _name.Trim(); }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname.Trim(); }
        }
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;

            if (CheckName(name) == false || CheckName(surname) == false)
            {
                Console.WriteLine("name or surname is inappropirate.");
                return;
            }

            GenerateEmail();

            _count++;
            _id = _count;
        }
        public static string Capitalise(string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }
        public static bool CheckName(string name)
        {
            Capitalise(name);

            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsLetter(name[i]))
                {
                    return true;
                }
                return false;
            }
            if (name.Length >= 3 && name.Length <= 25)
            {
                return true;
            }
            return false;
        }
        public string GenerateEmail()
        {
            CodeEmail = Name + "." + Surname + _id + "@code.edu.az";
            return CodeEmail;
        }
    }
}