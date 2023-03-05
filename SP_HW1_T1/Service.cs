using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SP_HW1_T1
{
    public class Service
    {
       
        public static void StartMyProcess(Process process)
        {
           
            process.Start();
           
        }
        public static void StartMyProcessAndWait(Process process)
        {
            if (process.Start())
            {
                process.WaitForExit();
                MessageBox.Show($"Процесс завершил работу с кодом {process.ExitCode.ToString()}");
            }
        }
    }
}
