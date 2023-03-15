
using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        private Guid _errorId;
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged; 
        
        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error)) //null, empty(""), whitespaces(" ")
                throw new ArgumentNullException();
                
            LastError = error;

            // Write the log to a storage
            // ...

            //ErrorLogged?.Invoke(this, Guid.NewGuid());
            //OnErrorLogged(Guid.NewGuid());
            _errorId= Guid.NewGuid();
            OnErrorLogged();
        }

        //public virtual void OnErrorLogged(Guid errorid) 
        protected virtual void OnErrorLogged()
        {
            //ErrorLogged?.Invoke(this, Guid.NewGuid());
            ErrorLogged?.Invoke(this, _errorId);
        }
    }
}