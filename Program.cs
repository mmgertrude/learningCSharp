
/*Summary

A Console application is one that can be made to run at the command
prompt on a windows machine.
The Console.write method can be used to write content to the console.*/



using System; //import existing .Net modules in our console application.

namespace learningCSharp
{

    /*Every application belongs to a class. C# is an object-oriented
     * language, and hence, all code needs to be defined in a 
     * self-sustaining module called a 'Class.' In turn, every class
     * belongs to a namespace. A namespace is just a logical grouping of classes.*/
    class Program
    {
        /*The Main function is a special function which is automatically 
         * called when a console application runs. */
        static void Main(string[] args)
        {

            /*The Console class is available in .Net which allows one
             * to work with console applications. Here we are using 
             * an inbuilt method called 'Write' to write the string 
             * "Hello World" in the console.*/
            Console.WriteLine("Hello World!");

            /*We then use the Console.ReadKey() method to read any key 
             * from the console. By entering this line of code, the
             * program will wait and not exit immediately. The program 
             * will wait for the user to enter any key before finally exiting. 
             * If you don't include this statement in code, 
             * the program will exit as soon as it is run.*/
            Console.ReadKey();
        }
    }
}
