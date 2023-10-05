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

        public void AddGrade(decimal grade)
        {
            float valueInDecimal = (float)grade;
            AddGrade(valueInDecimal);
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
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
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;


            return statistics;

        }

        public object GetStatistisc()
        {
            throw new NotImplementedException();
        }

        /*public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average+= grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }*/
    }
}
