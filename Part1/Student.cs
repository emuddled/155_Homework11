using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Student : IComparable
    {
        private string lastName;
        private string firstName;
        private int score;

        public Student()
        {

        }


        public Student(string first, string last, int score)
        {
            SetFirstName(first);
            SetLastName(last);
            SetScore(score);
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public int GetScore()
        {
            return score;
        }

        public void SetLastName(string last)
        {
            lastName = last;
        }
        public void SetFirstName(string first)
        {
            firstName = first;
        }
        public void SetScore(int s)
        {
            score = s;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Student otherStudent = obj as Student;
            
            return this.score.CompareTo(otherStudent.score);
            
        }
    }
}
