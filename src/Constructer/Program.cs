using System;

namespace Constructer
{
  public  class Student
    {

    public Student()
     {
      Console.WriteLine("invoke default constructer");
     }
    }
  class Teacher
{

          static void Main(string[] args)
        {
            Student s1= new Student();
            
            Console.WriteLine("Hello World!");
        }
  }
    }

