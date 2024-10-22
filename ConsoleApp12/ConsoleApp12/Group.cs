using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Group
    {
        public Student[] Students;
        public string GroupNo;
        public int StudentLimit;
        public Group(int limit )
        {
            Students = new Student[0];
            StudentLimit = limit;
            
        }

        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
                Console.WriteLine("Qrupa elave edildi");
            }
            else
            {
                Console.WriteLine("qrupda yer yoxdur");
            }

        }
        public void ShowInfo()
            
        {
            for(int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i].Id);
                Console.WriteLine(Students[i].Fullname);
                Console.WriteLine(Students[i].Point);
            }
             
        }
        public bool CheckGroupNo(string group)
        {
            bool group_adi;
            if (group.Length == 5 && char.IsUpper(group[0]) && char.IsUpper(group[1]) && char.IsDigit(group[2]) && char.IsDigit(group[3]) && char.IsDigit(group[4]))
            {
                group_adi = true;
            }
            else
            {
                group_adi = false;
            }
            return group_adi;
        }
        public void GetStudent(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Console.WriteLine(" Telebenin ad: " + Students[i].Fullname);
                    Console.WriteLine(" Telebenin point: " + Students[i].Point);
                }
            }
        }

    }
}
