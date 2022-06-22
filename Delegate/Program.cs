using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Exam> exams = new List<Exam>();
            string CountStr;
            int Count;
            do
            {
                Console.WriteLine("Imtahan sayini yazin:  ");
                CountStr = Console.ReadLine();

            } 
            while (!int.TryParse(CountStr , out Count));

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"{i+1}. Telebenin adini daxil edin: ");
                string student = Console.ReadLine();
                string Point;
                double point;
                do
                {
                    Console.WriteLine($"{i + 1}. Telebenin qiymetini daxil edin: ");
                    Point = Console.ReadLine();

                } 
                while (!double.TryParse(Point , out point));
                Console.WriteLine($"{i+1} imtahan fennini daxil edin: ");
                string Subject = Console.ReadLine();
                string StartDatestr;
                DateTime StartDate;
                do
                {
                    Console.WriteLine($"{i+1} Imtahanin baslama vaxtini yazin: ");
                    StartDatestr = Console.ReadLine();

                } 
                while (!DateTime.TryParse(StartDatestr, out StartDate));




                string EndDatestr;
                DateTime EndDate;
                do
                {
                    Console.WriteLine($"{i+1} imtahanin bitme vaxtini yazin: ");
                    EndDatestr = Console.ReadLine();

                } 
                while (!DateTime.TryParse(EndDatestr, out EndDate));

                Exam exam1 = new Exam()
                {
                    Student = student,
                    Point = point,
                    Subject = Subject,
                    StartDate = StartDate,
                    EndDate = EndDate

                };
                exams.Add(exam1);

                var wantedExam = exams.FindAll(x => x.Point > 49);
                Console.WriteLine("exams");
                foreach (var item in wantedExam)
                {
                    Console.WriteLine(item.Student+" "+ item.Point+" "+item.Subject);
                }


                // examLastWeek =exams.FindAll (x=>x.EndDate> examLastWeek.AddDays(7))
                
        
              
               
                
                    
               
                
            }
            
                
           


          
            

    }
    }
}