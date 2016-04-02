using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_1
{
    class Program
    {
        public static Random rnd = new Random();
        const string filePathInput = "Input.txt";
        const string filePathOutput = "Output.txt";


        static void Main(string[] args)
        {
            CreateAndInitializate();
            OutputResult();

        }

        //Input.txt create\generate
        public static void CreateAndInitializate()
        {
            
            const int maxLength = 100;

            try
            {
                if (!File.Exists(filePathInput))
                {
                    File.Create(filePathInput);
                }
                else
                {
                    string repo = null;

                    for (int i = 0; i <= maxLength; i++)
                    {
                        repo += rnd.Next(0, 2).ToString();
                    }

                    File.WriteAllText(filePathInput, repo);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Output
        public static void OutputResult()
        {
            try
            {
                string text = File.ReadAllText(filePathInput);
                var result = text.Split('0');

                if (!File.Exists(filePathOutput))
                {
                    File.Create(filePathOutput);
                }
                else
                {
                    File.WriteAllText(filePathOutput, result.Max().Length.ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
