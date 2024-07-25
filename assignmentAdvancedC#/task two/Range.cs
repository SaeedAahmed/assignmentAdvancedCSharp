using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentAdvancedC_.task_two
{
    internal class Range <T> where T : IComparable<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }

        public Range( T max , T min )
        {
            Max = max; 
            Min = min;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Max) <= 0 && value.CompareTo(Min) >= 0;
        }
        public T Length()
        {
            dynamic max = Max; 
            dynamic min = Min;
            return max - min;
        }
    }
}
