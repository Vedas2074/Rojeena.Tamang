using System;
using System.IO;

namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
           string fileContent = File.ReadAllText("test.txt");
           Console.WriteLine(fileContent);
        }

        public void LearnFileWriting()
        {
            File.WriteAllText("A.txt");
        }

        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.txt");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"File Size: {x} butes");
            Console.WriteLine($"Created: {y}");
            Console.WriteLine($"Created: {z}");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("abc");
            File.WriteAllText(@"abc\a.rojeena","This is my file");
        }

        internal void LearnDirectoryInfo()
        {
            string folderPath = @"G:\CSIT\6th sem\.net\rojina\Rojeena.Tamang";
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var files = directory.GetFiles();
            Console.WriteLine("File Count:" + files.Length);
        }
    }
}