using System.Diagnostics;

namespace OrdiOwin.Core
{
    public class Logger : ILogger
    {
        public void Write(string message, params object[] args)
        {
            Debug.WriteLine(message, args);
        }
    }
}
