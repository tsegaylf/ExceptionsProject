using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsProjectLibrary {
    public class Greater100Exception :Exception {

        public string AdditionalData { get; set; }

        public int i1 { get; internal set; }
        public int i2 { get; internal set; }

        public Greater100Exception() : base() {
        }
        public Greater100Exception(string message) : base(message) {
        }
        public Greater100Exception(string message, Exception innerException)
            : base(message, innerException) {
        }

    }
}
