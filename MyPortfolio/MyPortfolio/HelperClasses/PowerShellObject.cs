using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Threading;

namespace MyPortfolio.HelperClasses
{
    class PowerShellObject
    {
        public void CloseExplorer()
        {
            string script = "Stop-Process -processname explorer";
            RunScript(script);
        }
        private void RestartExplorer()
        {
            string script = "Start-Process -processname explorer";
            RunScript(script);
        }

        private void RunScript(string scriptText)
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                PowerShellInstance.AddScript(scriptText);
                IAsyncResult result = PowerShellInstance.BeginInvoke();
                while (result.IsCompleted == false)
                {
                    Console.WriteLine("Waiting for pipeline to finish...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Finished!");
                Console.Read();
            }
        }
    }
}
