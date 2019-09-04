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
            return i1 * i2;
        }

        public static int Div(int i1, int i2) {
            if(i1 == 17183) {
                throw new Ex17183Exception("Test Exception");
            }
            return i1 / i2;
        }


    }
}
