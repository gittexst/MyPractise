using System;
 public static class Math
    {
            public static string name="world";
            public static int square (int n){
              return n*n;
            }
      }
namespace Object3
{
   
    class Student
    {
        int id;
        String name;
        public void insertData(int i,String n){
         id=i;
         name=n;
        }

        public void displayData(){
            System.Console.WriteLine(" ID" +id + " NAME" +name);
        }
         /* public static void Main(string[] args){
        Console.WriteLine("the name is  "+ Math.name);
        Console.WriteLine("The square is " + Math.square(2));
         } */
        class Teacher{
        public static void Main(string[] args) {

        
              Student s1= new Student();

            s1.insertData(50,"me");
            s1.displayData();
        }
        }
    }
}
