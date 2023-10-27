using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo file = new FileInfo("D:\\SDET Training\\BasicSolution\\Files\\Sample.txt");

            using StreamWriter strw =  file.CreateText();
            Console.WriteLine("File has been created");

            strw.WriteLine("Hii");
            strw.WriteLine("Welcome!!");
            Console.WriteLine("Content Written");
        }

        public void WriteFile()
        {
            FileStream fileStream = new FileStream("newSample.txt",
                FileMode.Create,FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            Console.WriteLine("Enter the content to be written into the file");
            string? str = Console.ReadLine();
            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        public void ReadFile()
        {
            FileStream fileStream = new FileStream("D:\\SDET Training\\BasicSolution\\Files\\Sample.txt",
                FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fileStream);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = reader.ReadLine();

            while(str != null)
            {
                Console.WriteLine(str);
                str = reader.ReadLine();
            }
            reader.Close();
            fileStream.Close();
        }

        public void CopyMoveTo()
        {
            FileInfo fileInfo = new FileInfo("D:\\SDET Training\\BasicSolution\\Files\\Sample.txt");
            fileInfo.CopyTo("D:\\SDET Training\\BasicSolution\\Files\\Temp\\Sample.txt");

            FileInfo fileInfo1 = new FileInfo("D:\\SDET Training\\BasicSolution\\Files\\Sample1.txt");
            fileInfo1.MoveTo("D:\\SDET Training\\BasicSolution\\Files1\\Sample1.txt");

            Console.WriteLine("Process completed");
        }

        public void DeleteFile()
        {
            FileInfo fileInfo = new FileInfo("D:\\SDET Training\\BasicSolution\\Files1\\Sample1.txt");
            fileInfo.Delete();
            Console.WriteLine("File Deleted");
        }

        public void FileProperties()
        {
            FileInfo fileInfo = new FileInfo("D:\\SDET Training\\BasicSolution\\Files\\Sample.txt");

            Console.WriteLine("name: "+fileInfo.Name);
            Console.WriteLine("Length: "+fileInfo.Length.ToString());
            Console.WriteLine("Creation time:"+fileInfo.CreationTime.ToString());
            Console.WriteLine("last Access: "+fileInfo.LastAccessTime);
            Console.WriteLine("Last written: "+fileInfo.LastWriteTime);
            Console.WriteLine("Full name: "+fileInfo.FullName);
            Console.WriteLine("Exists: "+fileInfo.Exists);
        }
    }
}