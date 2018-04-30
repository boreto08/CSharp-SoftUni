using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Files
{
    class Files
    {
        static void Main()
        {
            List<FileCustom> files = new List<FileCustom>();
            int pathCount = int.Parse(Console.ReadLine());
            List<string> paths = new List<string>();
            for (int i = 0; i < pathCount; i++)
            {
                paths.Add(Console.ReadLine());
            }
            var args = Console.ReadLine().Split(new string[] { "in" }, StringSplitOptions.RemoveEmptyEntries);
            var root = args[1].Trim();
            var extension = args[0].Trim();

            foreach (var path in paths)
            {
                var pathArgs = path.Split('\\');
                var pathRoot = pathArgs[0];

                if (root != pathRoot)
                {
                    continue;
                }

                var pathExtensionAndSize = Path.GetExtension(path).Split(';');
                var pathExtension = pathExtensionAndSize[0].TrimStart('.');
                if (extension != pathExtension)
                {
                    continue;
                }
                var getFileNameArgs = Path.GetFileName(path).Split(';');
                var fileName = getFileNameArgs[0].Trim();
                ulong size = ulong.Parse(pathExtensionAndSize[1]);

                FileCustom currentFile = new FileCustom(fileName, size);
                files.Add(currentFile);
            }
            if (files.Count > 0)
            {
                PrintFiles(files);
            }
            else
            {
                Console.WriteLine("No");
            }
            

        }

        private static void PrintFiles(List<FileCustom> files)
        {
            foreach (var file in files.OrderBy( f => f.Size).ThenBy(f => f.Name))
            {
                Console.WriteLine($"{file.Name} - {file.Size} KB");
            }
        }
    }

   
}
