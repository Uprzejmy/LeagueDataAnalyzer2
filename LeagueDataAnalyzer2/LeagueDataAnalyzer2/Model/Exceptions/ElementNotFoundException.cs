using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.Model.Exceptions
{
    class ElementNotFoundException : Exception
    {
        public ElementNotFoundException() : base()
        {

        }

        public ElementNotFoundException(string message) : base(message)
        {

        }

        public ElementNotFoundException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
