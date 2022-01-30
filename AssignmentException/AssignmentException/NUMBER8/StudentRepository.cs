using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentException.NUMBER8
{
    public class FileText
    {
        
       public static void Files()
        {
            string FileName = "Student.txt";
            Console.WriteLine(ReadFile(FileName));
        }
        
        public static string ReadFile(string filename)
        {
            
            try
            {
                
                string file = "C:\\Users\\user\\source\repos\\AssignmentException\\AssignmentException\\File\\Student.txt";
                if (File.Exists(file))
                {
                    List<string> Lines = File.ReadAllLines(file).ToList();
                    Lines.Add("this is a blue shirt");
                    File.WriteAllLines(file, Lines);
                    if (Lines.Count == 0)
                    {
                        throw new Invalidnumberexpression("empty file");
                    }
                    else
                    {
                        foreach (var word in Lines)
                        {
                            return word.ToString();
                        }
                    }
                }
                else
                {
                    string path = "C:\\Users\\user\\source\repos\\AssignmentException\\AssignmentException\\File";
                    Directory.CreateDirectory(path);
                    string fileName = filename;
                    string fullpath = Path.Combine(path, filename);
                    File.CreateText(fullpath);
                }
            }
            catch(Invalidnumberexpression ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("add something to file");
            }
            return null;
        }
       
        
    }
}
