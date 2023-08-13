using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Repository
    {
        List<Appointment> appointments = new List<Appointment>();

        public void AddAppointment()
        { 

            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            Console.Write("Enter Contact: ");
            var contact = Console.ReadLine();
            Appointment appointment = new Appointment(name, contact);
            appointment.ID = appointments.Count+1;
            appointments.Add(appointment);
            Console.WriteLine("Added successfully");

        }
        public void delete()
        {
            bool found = false;
            Console.WriteLine("Enter ID you wanna delete: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<appointments.Count;i++ ) 
            {
                if (input == appointments[i].ID)
                {
                    appointments.Remove(appointments[i]);
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("Deleted successfully");
            }

        }
        public void display()
        {
            foreach (var appointment in appointments)
            {
                Console.WriteLine(appointment.ToString());
            }
        }
    }
}
