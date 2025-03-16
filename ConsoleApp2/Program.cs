using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Structs 
 * Just like classes, structs can have 
 * private fields, public properties, constructors, methods, etc.
 */

namespace CSharpConcepts
{
    public struct Customer
    {
        private int _id;
        private string _name;

        // set and get accessor    
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // constructor
        public Customer(int Id, string Name)
        {
            _id = Id;
            _name = Name;
        }
        //Method
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", _id, _name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
              Customer c1 = new Customer(101, "Mark");
            c1.PrintDetails();
            Customer c2 = new Customer();
            c2.Id = 102;  
            c2.Name = "John";
            c2.PrintDetails();
            Customer c3 = new Customer
            {
                Id = 103,
                Name = "Rob"
            };
            c3.PrintDetails();

        }

    }
}
/*  
 *  Difference between class and struct
 *  struct is value type and class is reference type.
 *  struct are stored on stack and class are stored on heap.
 *  when you copy a struct to another struct, a new copy of the struct will be created.
 *  But when you copy a class to another class, both will point to the same memory location.
  *  struct can't have destructors but class can have destructors.
  *  struct can't have explicit parameterless constructor but class can have.
  *  struct can't inherit from another struct but class can inherit from another class.
  *  A class can inherit from a struct.struct are sealed type, so they can't be inherited. 
  */