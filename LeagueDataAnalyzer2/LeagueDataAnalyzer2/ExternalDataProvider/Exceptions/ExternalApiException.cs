using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider.Exceptions
{
    [Serializable]
    class ExternalApiException : Exception
    {
        public ExternalApiException() : base()
        {

        }

        public ExternalApiException(string message) : base(message)
        {

        }

        public ExternalApiException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
