using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class StudentGroup
    {
        private List<Student> students;


        public StudentGroup()
        {
            students = new List<Student>();
        }
        public void AddStudent(object stu)
        {
            students.Add(stu as Student);

        }

        public double GetAverageScore()
        {
            int total = 0;
            int count = 0;
            foreach (Student s in students)
            {
                total += s.GetScore();
                count++;
            }
            return total / (count * 1.0);
        }

        public int GetMedianScore()
        {
            students.Sort();
            if (students.Count % 2 == 0)
            {
                return (students[(students.Count / 2)].GetScore() + students[(students.Count / 2 + 1)].GetScore()) / 2;
            }
            else
            {
                return students[students.Count / 2].GetScore();
            }                
        }
    }

}
