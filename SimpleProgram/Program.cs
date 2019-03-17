using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    StringToIntConverter converter = new StringToIntConverter();
                    converter.convert(Console.ReadLine());
                }

                catch(Exception ex)
                {
                    Console.WriteLine("There was an error with the conversions: {0}",ex.InnerException);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(" There was an error : {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Rest of my Application is still running");
            }

        }
    }
}
