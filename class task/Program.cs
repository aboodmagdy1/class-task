using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Person
    {
        int age; 
        string name;
        string sex;
        string town;
        int phone_number;
        string study;
        string marital_status;
        string job;
        string adress;

        //no arg  constractor 
        public Person() { }

        //frist arg constractor 
        public Person(string name)
        {
            this.name = name;
        
        }
        //scond arg constractor 
        public Person(int age , string name)
        {
            this.age = age;
            this.name=name;
        }
        //3th arg constractor  if the perosn is student 
        public Person(string sex, string name, int age , string town ,string study ,string adress ,int phone_number , string marital_status ) 
        { 
        this.sex = sex;
        this.name = name;
        this.study = study;
        this.town=town;
        this.phone_number = phone_number;
        this.adress = adress;
        this.marital_status = marital_status;
        this.age = age;

        
        }
        //4th arg constractor if the person is employee
        public Person(string name, int age, string town, string job, string adress, int phone_number, string marital_status,string sex)
        {
        this.sex = sex;
        this.name = name;
        this.job = job;
        this.town = town;
        this.phone_number = phone_number;
        this.adress = adress;
        this.marital_status = marital_status;
        this.age = age;


        }

         public  void set_name_and_age(string The_name , int The_age)
        {

            name = The_name;
            age = The_age;

        
        
         }
        public void set_sex_and_marital_status( string sex ,string marital_status) 
        {
            this.sex = sex; 
           this. marital_status = marital_status;

        }
        public void set_adress(string adress, string town) {
            this.adress = adress; 
            this.town=town;
        }

        public string get_name() {
        
        return this.name;
        
        }

        public string get_adress()
        {
            return this.adress;
        }

        public int get_phone_number() {

            return this.phone_number;
        }



    











    }
}
