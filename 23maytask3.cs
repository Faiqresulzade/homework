using System;

namespace ConsoleApp12
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Student myresult = new Student
            {
               HomeworkGrades =new int[] {60,50,40 } ,
               ProjectGrades=new int[] {30,20,10},
               FinalGrade=55,
               Davamiyyet=new bool[] {true,false ,false,true,true}
            };
            myresult.Result(new int[] { 91,92,94 }, new int[] { 95,96,97 }, 99, new bool[] { true, false, false, true, true });
        }
    }
    class Student
    {
        public int [] HomeworkGrades;
        public int [] ProjectGrades;
        public int FinalGrade;
        public bool[] Davamiyyet;

        public void Result(int[] HomeworkGrades, int[] ProjectGrades, int FinalGrade, bool[] Davamiyyet)
        {
            int HomeworkGradessum = 0;
            int ProjectGradessum = 0;
            double avg;
            double avg2;
            int count =0;
            double avg3;
            for (int i = 0; i <HomeworkGrades.Length; i++)
            {
                HomeworkGradessum += HomeworkGrades[i];
               
            }
            avg = HomeworkGradessum / HomeworkGrades.Length;
           
            foreach (var item in ProjectGrades)
            {
                ProjectGradessum += item;
            }
            avg2 = ProjectGradessum / ProjectGrades.Length;
            // Davamiyyet = new bool[] { true, false, false, true, true }
            foreach (var item in Davamiyyet)
            {
                if (item ==true)
                {
                    count++;
                }
               
            }
            avg3 = count* 10 / Davamiyyet.Length;
            if(0.25* avg+0.25*avg2+avg3+0.4* FinalGrade > 90)
            {
                Console.WriteLine("HighHonour");
                return;
            }
            if (0.25 * avg + 0.25 * avg2 + avg3 + 0.4 * FinalGrade > 80 && 0.25 * avg + 0.25 * avg2 + avg3 + 0.4 * FinalGrade < 90)
            {
                Console.WriteLine("Honour");
                return;
            }
            else
                Console.WriteLine("Normal");
        }
    }
}
