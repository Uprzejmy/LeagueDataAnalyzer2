using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueDataAnalyzer2.ExternalDataProvider.Exceptions
{
    [Serializable]
    class ResourceNotFoundException : ExternalApiException
    {
        public ResourceNotFoundException() : base()
        {

        }

        public ResourceNotFoundException(string message) : base(message)
        {

        }

        public ResourceNotFoundException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
