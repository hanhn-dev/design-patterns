using System;

namespace DesignPatterns.Composite
{
    public class CompositeLauncher : Launcher
    {
        public CompositeLauncher() : base("Composite")
        {   
        }

        public override void Run()
        {
            Console.WriteLine("********** File System **********");
            var root = new DirectoryItem("projects");
            var project1 = new DirectoryItem("project1");
            var item1Project1 = new FileItem("ItemTxt1", 2100);
            var item2Project1 = new FileItem("ItemTxt2", 3100);
            var project11 = new DirectoryItem("project1.1");
            var item1Project11 = new FileItem("ItemTxt1.1", 4100);
            var item2Project11 = new FileItem("ItemTxt2.1", 5100);            
            project11.Add(item1Project11);
            project11.Add(item2Project11);
            project1.Add(item1Project1);
            project1.Add(item2Project1);
            project1.Add(project11);
            var project2 = new DirectoryItem("project2");
            
            root.Add(project1);
            root.Add(project2);

            Console.WriteLine($"Total byte sizes: {root.GetSizeInKb()}");
        }
    }
}
