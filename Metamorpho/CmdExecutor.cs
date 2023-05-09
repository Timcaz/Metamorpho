using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Metamorpho
{
    internal class CmdExecutor
    {
        private const int n = 0;
        private bool stopRequested;
        public event EventHandler<int> ProgressChanged;
        int MaxConcurrentCommands;
        int progress;

        public delegate void ProgressChangedDelegate(int progress);

        public CmdExecutor() 
        {
            this.MaxConcurrentCommands = 1;
            progress = 0;
        }
        public void RequestStop()
        {
            stopRequested = true;
        }
        public async Task ExecuteCommands(List<string> commands,int MaxConcurrentCommands)
        {
            int runningCommands = 0;
            foreach (string command in commands)
            {
                while (runningCommands >= MaxConcurrentCommands)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
                if (stopRequested) break;

                runningCommands++;

                Task.Run(() =>
                {
                    try
                    {
                        ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", $"/c {command}");
                        processStartInfo.RedirectStandardOutput = true;
                        processStartInfo.UseShellExecute = false;
                        processStartInfo.CreateNoWindow = true;

                        using (Process process = new Process())
                        {
                            process.StartInfo = processStartInfo;
                            process.Start();
                            process.WaitForExit();

                            Console.WriteLine($"Command '{command}' completed with exit code {process.ExitCode}");
                        }
                    }
                    finally
                    {
                        progress++;
                        OnProgressChanged(progress);
                        runningCommands--;
                    }
                });
            }

            while (runningCommands > 0)
            {
                if (stopRequested) break; 
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            progress = 0;
        }
        protected virtual void OnProgressChanged(int progress)
        {
            ProgressChanged?.Invoke(this, progress);
        }
    }
}
