using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM22Nov24ExceptionHandlingEntLib
{
    internal class DestructorEx
    {
        static void Main() 
        {

            Employee obj = new Employee();
            obj = null;

            GC.WaitForPendingFinalizers();

            GC.Collect();


             obj = new Employee();
            obj.Dispose();



            using (obj= new Employee ())
            {

                Console.WriteLine(  obj.EmpID);
            }


            obj = null;

            Console.WriteLine("End of Main");
            Console.ReadKey();



        }

    }



    class Employee:IDisposable
    {
        private bool disposedValue;

        public int EmpID
        { get; set; }


        ~Employee()
        {
            Console.WriteLine(  "Destructor Called .....");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Employee()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Console.WriteLine(  "Disposed Called ....");
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }


    class dept

    {

    }
}
