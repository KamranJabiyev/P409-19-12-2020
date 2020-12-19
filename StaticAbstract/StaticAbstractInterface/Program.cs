using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Static
            //Person p = new Person();
            //p.Name = "Orxan";
            //p.Surname = "Huseynov";

            //Console.WriteLine(p.Name);
            //Person.Age = 20;
            //p.Fullname();
            //Console.WriteLine(Person.Age);
            //Person.GetData();
            //Console.WriteLine(x);

            //Person p = new Person();
            //Person p1 = new Person();
            //Person p2 = new Person();

            //Console.WriteLine(p.number);
            //Console.WriteLine(p1.number);
            //Console.WriteLine(p2.number);
            //Console.WriteLine($"p1: number={p1.number}, count={Person._count}");
            //Console.WriteLine($"p: number={p.number}, count={Person._count}");

            //Test.MyProperty = 10;
            //Test.Hello();
            #endregion

            #region Abstract
            //Animal animal = new Animal(); 
            //Eagle eagle = new Eagle();
            //eagle.Eat();
            #endregion

            #region Sealed
            Student student = new Student("Pervin","Semedov");
            Console.WriteLine(student.Name);
            #endregion
        }

        public static int x = 10;
    }

    #region Sealed
    //sealed class-can not get inheretance
    sealed class Student:Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
    }

    //class Developer : Student
    //{

    //}
    #endregion

    #region Abstract
    //abstract class - can not get instance,contains abstract method
    abstract class Animal
    {
        public int test;
        public abstract void Eat();
        public void Wild()
        {
            Console.WriteLine("Yes");
        }

        public virtual void Live()
        {
            Console.WriteLine("Live as Animal");
        }
    }

    abstract class Bird:Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    abstract class Fish:Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish
    {

        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }
    #endregion

    #region Static
    //static class - all members must be static,can not get instance,can not inheretance!!!
    //static class Test
    //{
    //    static Test()
    //    {
    //        Console.WriteLine("Test ctor");
    //    }
    //    public static int MyProperty { get; set; }
    //    public static void Hello()
    //    {

    //    }
    //}

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public  int Age { get; set; }
        public static int _count=0;
        public int number;

        //static ctor-parametrless, worked only once,can not call!!! 
        static Person()
        {
            Console.WriteLine("First person created");
        }
        public Person()
        {
            _count++;
            number=_count;
        }
        public static void GetData()
        {
            Console.WriteLine($"Person's static method");
        }

        public void Fullname()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
    #endregion
}
