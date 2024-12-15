using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_movies_
{
    public class Person
    {
        public string FullName { get; set; }
        public string ContactInfo { get; set; }

        public Person() { }

        public Person(string fullName, string contactInfo)
        {
            FullName = fullName;
            ContactInfo = contactInfo;
        }


        public string GetInfo()
        {
            return $"Name: {FullName}, Contact: {ContactInfo}";
        }
    }

}
