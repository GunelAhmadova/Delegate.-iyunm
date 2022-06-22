using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Exam
    {
        public string Student;
        public double Point;
        public string Subject;
        public DateTime StartDate;
        public DateTime EndDate;
        public TimeSpan Duration { get => EndDate - StartDate; }
    
        
    }
}
