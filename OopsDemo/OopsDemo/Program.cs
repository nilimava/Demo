using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Remoting;
using System;
using System.Text;
using System.Xml.Linq;

namespace OopsDemo
{
  
   public class Modifiers
    {
       
        static void Main(string[] args)
        {
            //reference type -pass by value

            Person person = new Person(){ Name = "John"};

            UpdateName(person); //passing reference (person) to method
            Console.WriteLine(person.Name);
            Console.ReadKey();
        }

        public static void UpdateName(Person p) //ref of person is copied into p
        {
            //p = new Person { Name = "Max" }; //now  p is pointing to new object instead of old object
            p.Name = "Max";
        }
    }
}




