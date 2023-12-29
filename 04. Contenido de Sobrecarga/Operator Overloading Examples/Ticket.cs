using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Examples
{
    internal class Ticket
    {
        //Duration 
        public int DurationInHours { get; set; }
        public DateTime CreationDate { get; set; }

        // Simple Constructor
        public Ticket(int durationInHours)
        {
            // Set the duration in hours
            DurationInHours = durationInHours;
            // Set the creation date DateTime.now
            CreationDate = DateTime.Now;
        }

        public static Ticket operator +(Ticket a, Ticket b)
        {
            return new Ticket(a.DurationInHours + b.DurationInHours);
        }
    }
}
