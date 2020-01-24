using System;
using System.IO;
using System.Text;

namespace learning_c_sharp
{
    public class Files
    {
        private readonly string path = "/Users/alexander/Desktop/csharp/learning_c_sharp/learning_c_sharp/";
        private readonly string file = "07_Files.cs";


        public Files()
        {
            Console.WriteLine("====> Configuring files");
            ExecuteFileCommands();
        }


        private void ExecuteFileCommands()
        {
            string currentFile = path + file;
            var displayText = new StringBuilder();

            displayText
                .Append(file)
                .Append(" was created on: ")
                .Append(File.GetCreationTime(currentFile))
                .AppendLine();

            Console.WriteLine(displayText);
        }
    }
}
