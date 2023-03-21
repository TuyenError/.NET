using kethua;
using System;

namespace kethua
{
    public class Person
    {
        //Thuộc tính
        private string name;
        //Phương thức
        private int age;
        public Person()
        {
            name = " Cao Tuyen";
            age = 21;
        }
        public Person (string ten, int tuoi)
        {
            name = ten;
            age = tuoi;
        }
        public void Display()
        {
            Console.WriteLine("Ho ten la {0}",name);
            Console.WriteLine("Tuoi la {0}", age);
        }
        public class Staff : Person
        {
            private int workingyear;
            private double salary;
            public Staff(string ten, int tuoi,int namctac,double luong): base(ten, tuoi)
            {
                workingyear = namctac;
                salary = luong; 
            }
            public void Show()
            {
                Display();
                Console.WriteLine("Nam cong tac {0}", workingyear);
                Console.WriteLine("Luong la {0}", salary);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Person p1 = new Person();
        p1.Display();
    }
}