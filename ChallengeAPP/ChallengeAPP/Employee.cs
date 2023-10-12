﻿using System.Diagnostics;
using System.Xml.Schema;

namespace ChallengeAPP
{
    public class Employee 
    {
        private List<float> grades = new List<float>();

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade); ;
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(double grade)
        {
            float valueInDouble = (float)grade;
            AddGrade(valueInDouble);
        }

        public void AddGrade(long grade)
        {
            float valueInLong = (float)grade;
            AddGrade(valueInLong);
        }

        public void AddGrade(char grade)
        {

            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }
            
        }

        public void AddGrade(string grade)
        {

            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                char grade1 = char.Parse(grade);
                AddGrade(grade1);
            }
            else 
            {
                Console.WriteLine("String is not float");
            }
          
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average = statistics.Average + grade;
                }
            }

            statistics.Average = statistics.Average / this.grades.Count;
            
            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            
            return statistics;
        }
     }      
}
