using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine_ConsoleApp_
{
    class CountException:Exception
    {
        private string _message;
        public CountException(string message)
        {
            _message = message;
        }
        public override string Message => _message;
    }
}
