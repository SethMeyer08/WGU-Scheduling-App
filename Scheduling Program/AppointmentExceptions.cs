using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969___Seth_Meyer___Scheduling_Software
{
    class AppointmentExceptions : ApplicationException
    {
        public void BusinessHours()
        {
            MessageBox.Show("Please schedule during normal business hours. (8 AM - 5 PM)");
        }

        public void ApptOverlap()
        {
            MessageBox.Show("Error! Appointment times cannot overlap.");
        }

        public AppointmentExceptions(string message) : base(message)
        {

        }

        public AppointmentExceptions(string message, Exception innerException) : base(message, innerException)
        {

        }

        public AppointmentExceptions()
        {

        }
    }
}
