using System.Diagnostics;


namespace Drew{
    class MainClass{        
        static void Main(string[] args){
            Random rand = new Random();
            var initialRunTime = rand.NextInt64(0,10);

            Process process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "./Script.bat";

            Thread.Sleep((int)initialRunTime*1000);
            process.Start();

            while(true){
                long timeDelay = rand.NextInt64(0,10);
                Thread.Sleep((int)timeDelay*1000);
                process.Start();
                Console.WriteLine(timeDelay);
            }
        }
    }
}
