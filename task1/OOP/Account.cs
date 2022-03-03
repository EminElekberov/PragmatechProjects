using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Account
    {
        
        public abstract bool PasswordChecker(string pass);
        public virtual void ShowInfo()
        {
            
        }
    }
}
