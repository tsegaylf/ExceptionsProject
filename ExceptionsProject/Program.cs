using System;
using My = ExceptionsProjectLibrary;

namespace ExceptionsProject {
    class Program {

        void Run() {
            try {
                var ans = My.Math.Add(1, 2);
                ans = My.Math.Sub(ans, 2);
                ans = My.Math.Mult(0, ans);
                ans = My.Math.Div(17183, 1);
                Console.WriteLine($"Answer is {ans}");
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("Finally Block");
            }

        }

        static void Main(string[] args) {
            var pgm = new Program(); 
            pgm.Run();
        }
    }
}
