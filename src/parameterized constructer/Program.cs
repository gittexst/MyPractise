using System;


   public  class Student
    {
       public int id;
        public String name;

       public Student(int i,String n){
          id=i;
              name=n;

        }
        public void insertData(){
       Console.WriteLine( id + " " + name + " ");
           
        }
    }

    class Teacher{
       public static void Main(string[] args)
        {
           Student e1= new Student(50,"raj");
           e1.insertData();

           
        }
    }
    

    
    

