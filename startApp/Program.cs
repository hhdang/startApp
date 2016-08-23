using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace startApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ArrayProcessName = "InRun";
            string[] processName = ArrayProcessName.Split(',');

            foreach( string appName in processName ){
                Process[] localByNameApp = Process.GetProcessesByName( appName );

                if( localByNameApp.Length > 0 ){
                    foreach( Process app in localByNameApp ){
                        if( !app.HasExited ){
                            System.Console.WriteLine( app.ProcessName + " exsiting." );
                        }else{
                            System.Console.WriteLine(app.ProcessName + " has exited.");
                        }
                    }
                }
            }
        }
    }
}
