using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using RazorGenerator.MsBuild;

namespace TestingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //find out how to initialize Engine property of the Task in .NET 4 version of MSBuild
            Engine engine = new Engine();
            engine.BinPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System)
                + @"\..\Microsoft.NET\Framework\v2.0.50727";

            FileLogger logger = new FileLogger();
            logger.Parameters = @"logfile=C:\temp\test.msbuild.log";
            engine.RegisterLogger(logger);

            string[] tasks = new string[] { "MyTask" };
            BuildPropertyGroup props = new BuildPropertyGroup();
            props.SetProperty("parm1","hello Build!");

            var task = new RazorCodeGen();
            const string path = @"C:\work\projects\SyncCloud.Backend\AirPlans.Web\";
            task.ProjectRoot = path;
            task.CodeGenDirectory = Path.Combine(task.ProjectRoot, @"obj\CodeGen\Views\");
            var allViewFiles = Directory.EnumerateFiles(Path.Combine(task.ProjectRoot, @"Views\"), "*.cshtml", SearchOption.AllDirectories).ToList();
            task.FilesToPrecompile = allViewFiles.Select(x => new TaskItem(x)).ToArray();

            task.Execute();

            Console.ReadKey();
        }
    }
}
