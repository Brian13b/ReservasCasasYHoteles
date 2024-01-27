using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LabII
{
    internal class MisExcepciones:ApplicationException
    {
        public MisExcepciones() { }

        public MisExcepciones(string message) : base(message) { }

        public MisExcepciones(string message, Exception innerException) : base(message, innerException) { }
    }
}
