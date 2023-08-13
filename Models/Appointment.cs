using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Appointment:IEnumerable
    {
        public  int ID { get; set; }
        public string name { get; private set; }
        public string contact { get; private set; }
        public DateTime bookingDate { get; private set; }

        public Appointment(string _name, string _contact)
        {
            name = _name;
            contact = _contact;
            bookingDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $@"ID: {ID} , Name: {this.name} , contact: {contact} , Creation Date: {bookingDate}";
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
