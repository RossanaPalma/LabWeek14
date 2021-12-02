/// Chapter No. 31 - LabWeek14
/// File Name: LabWeek14.java
/// @author: Rossana Palma
/// Date:  November 29, 2021
///
/// Problem Statement: Create 2 methods and assign the method to the 
/// delegate and use the method via the delegate.



using System;
//using static Week_14_Examples.rectangle;

namespace LabWeek14
{
    class rectangle
    {
        static void Main(string[] args)
        {
            //A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods. 
            //Delegates in C# are similar to the function pointer in C/C++. 
            //It provides a way which tells which method is to be called when an event is triggered.
            // 
            // creating object of class  
            // "rectangle", named as "rect" 
            rectangle rect = new rectangle();

            // these two lines are normal calling 
            // of that two methods 
            // rect.area(6.3, 4.2); 
            // rect.perimeter(6.3, 4.2); 

            // creating delegate object, name as "rectdele" 
            // and pass the method as parameter by  
            // class object "rect" 
            rectDelegate rectdele = new rectDelegate(rect.area);

            // also can be written as  
            // rectDelegate rectdele = rect.area; 

            // call 2nd method "perimeter" 
            // Multicasting 
            //rectdele += rect.perimeter;
            rectdele = rectdele + new rectDelegate(rect.perimeter);

            // pass the values in two method  
            // by using "Invoke" method 
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            // call the methods with  
            // different values 
            rectdele.Invoke(16.3, 10.3);
        }

        // declaring delegate 
        public delegate void rectDelegate(double height, double width);

        //"area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        //"perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }


    }
}


