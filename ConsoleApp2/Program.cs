using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Student {
        private int _id;
        private string _name;
        private int _passMarks = 35;
        public string city { set; get; }
        public string email { set; get; }


        public int Id
        {
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("student Id can not be null");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

       

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }
       
       public void SetPassMakrs(int PassMakrs)
        {
            this._passMarks = PassMakrs;
        }
        public int passMakrs
        {
            get
            {
                return (int)this._passMarks;
            }
        }
            
    }
      
    class Program
    {
        static void Main(string[] args)
        {
             
            Student student = new Student();
            student.Id =22;
            student.Name ="Kira";
            student.city = "Bangalore";
            student.email = "Kira@gmail.com";
            Console.WriteLine("Student Id ={0}",student.Id);
            Console.WriteLine("Student Name ={0}",student.Name);
            Console.WriteLine("studen PassMarks ={0}", student.passMakrs);
            Console.WriteLine("studen City ={0}", student.city);
            Console.WriteLine("studen Email ={0}", student.email);


        }
    }
}
