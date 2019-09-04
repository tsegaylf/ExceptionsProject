using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsProjectLibrary {

    public class Math {

        public static int Add(int i1, int i2) {
            return i1 + i2;
        }
        
        public static int Sub(int i1, int i2) {
            return i1 - i2;
        }

        public static int Mult(int i1, int i2) {
            if (i1 * i2 > 100) {
                var ex = new Greater100Exception("In Math.Mult()");
                ex.i1 = i1;
                ex.i2 = i2;
                throw ex;
            }
            return i1 * i2;
        }

        public static int Div(int i1, int i2) {
            if(i1 == 17183) {
                var ex = new Ex17183Exception("Test Exception");
                ex.AdditionalData = "In the DIV method";
                throw ex;
            }
            return i1 / i2;
        }


    }
}
