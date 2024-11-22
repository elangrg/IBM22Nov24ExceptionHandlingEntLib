using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM22Nov24ExceptionHandlingEntLib
{
    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {

            int i = 0;
            try
            {

                try
                {
                    Console.Write("Enter Number:"); i = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Specific :" + e.Message);


                    // sce 1 - Recovered

                    // sce 2 - Not Recovered Forward Exception 

                    // throw;

                    // scenario 3  report Current Failure Along with the Recieved Exception

                    throw new ArgumentNullException("Argument Is Invalid...", e);
                }
                finally 
                {
                    Console.WriteLine( "Inner: Finally Called ");
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Specific :" + e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("General :" + e.ToString());
            }
            catch
            {
                Console.WriteLine("General : Error Occured");
            }
            finally
            {
                Console.WriteLine("Outer: Finally Called ");
            }



            Console.WriteLine(  "You Entered :" + i);
            Console.ReadKey();



        }
    }
}
