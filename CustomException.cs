using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem  //UC3
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            CONSTRUCTOR_NOT_FOUND,
            CLASS_NOT_FOUND
        }
        public ExceptionType Type;

        public CustomException(ExceptionType type, string message) : base(message)
        {
            Type = type;
        }
    }
}
