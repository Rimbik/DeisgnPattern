using System;
using System.IO;

namespace Singleton_Pattern
{
    public sealed class ErrorLogger
    {
        private static readonly ErrorLogger _instance = new ErrorLogger();


        private ErrorLogger()
        {
          
        }

        public static ErrorLogger GetLogger()
        {
            return _instance;
        }

        public void Write(string logInformation)
        {
            
            string[] lines = { System.Environment.NewLine, "First line", "Second line", "Third line" };

            // Set a variable to the Documents path.
            string docPath = @"D:\temp\LogError";
            //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Append new lines of text to the file
            File.AppendAllLines(Path.Combine(docPath, "WriteFile.txt"), lines);
        }
    }
}
