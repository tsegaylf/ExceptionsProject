using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsProjectLibrary {
    public class Ex17183Exception : Exception {

        public string AdditionalData { get; set; }

        public Ex17183Exception() : base() {
        }
        public Ex17183Exception(string message) : base(message) {
        }
        public Ex17183Exception(string message, Exception innerException)
            : base(message, innerException) {
        }
    }
}
