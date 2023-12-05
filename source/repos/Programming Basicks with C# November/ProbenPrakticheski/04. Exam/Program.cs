using System;

namespace _04._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());



            int studentCounterGroup1 = 0;
            int studentCounterGroup2 = 0;
            int studentCounterGroup3 = 0;
            int studentCounterGroup4 = 0;

            double sumGrade = 0.0;
            double grade = 0.0;

            for (int i = 0; i < numOfStudents; i++)
            {
                grade = double.Parse(Console.ReadLine());
                sumGrade = sumGrade + grade;

                if (grade < 3)
                {
                    studentCounterGroup4++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    studentCounterGroup3++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    studentCounterGroup2++;
                }
                else if (grade >= 5.00 && grade <= 6.00)
                {
                    studentCounterGroup1++;
                }
            }
            double studentCounterGroup1InPercents = (double)studentCounterGroup1 / numOfStudents * 100;
            double studentCounterGroup2InPercents = (double)studentCounterGroup2 / numOfStudents * 100;
            double studentCounterGroup3InPercents = (double)studentCounterGroup3 / numOfStudents * 100;
            double studentCounterGroup4InPercents = (double)studentCounterGroup4 / numOfStudents * 100;



            double averageGrade = sumGrade / numOfStudents;


            //Ред 1 - "Top students: {процент студенти с успех 5.00 или повече}%"
            //Ред 2 - "Between 4.00 and 4.99: {между 4.00 и 4.99 включително}%"
            //Ред 3 - "Between 3.00 and 3.99: {между 3.00 и 3.99 включително}%"
            //Ред 4 - "Fail: {по-малко от 3.00}%"
            //Ред 5 - "Average: {среден успех}"

            Console.WriteLine($"Top students: {studentCounterGroup1InPercents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {studentCounterGroup2InPercents:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {studentCounterGroup3InPercents:F2}%");
            Console.WriteLine($"Fail: {studentCounterGroup4InPercents:F2}%");

            Console.WriteLine($"Average: {averageGrade:F2}");



        }
    }
}