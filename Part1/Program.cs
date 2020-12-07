/// Homework No. 11  	Exercise Part 1
/// File Name: Student
/// @author: Evan Sinclair
/// Date:  Nov 30, 2020
///
/// Problem Statement: Create a Student class and have the Student Class implement the IComparable interface.  This 
/// interface will compare the Student’s score.  The Student class with also have first and last name fields.  Create 
/// the appropriate constructors as well as getters and setters for the Student class.
/// Create a Student information file.  The file is organized the same way as the Student class. Read in this file 
/// and populate a List of Students.  After the list of students is created you will need to compute the average and 
/// median of student scores.  You will write this information out to a file called StudentStats.txt.  As a reminder 
/// the median calculation will vary whether there is an odd or even number of elements in the list.
/// 
/// 
/// 
/// Overall Plan:
/// 1) Create Student class that implements IComparable
/// 2) Create StudentGroup class that contains List<Student> and calculates median and average scores
/// 3) Use StreamReader to read in data files
/// 4) Use StreamWriter to write out averages and medians to a file 
///



using System;
using System.IO;
namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentGroup students = new StudentGroup();
            
            try
            {
                
                // 2 text files to test out even and odd Median
                //StreamReader sr = new StreamReader("input2.txt"); 
                StreamReader sr = new StreamReader("input1.txt");
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] data = line.Split(' ');
                        
                        Student stu = new Student(data[0], data[1], Convert.ToInt32(data[2]));
                        students.AddStudent(stu);

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error reading from file:");
                Console.WriteLine(e.Message);
            }

            StreamWriter outFile = new StreamWriter("output.txt", false);

            outFile.WriteLine("Average student score: " + students.GetAverageScore());
            outFile.WriteLine("Median student score: " + students.GetMedianScore());
            outFile.Close();
        }
    }
}
