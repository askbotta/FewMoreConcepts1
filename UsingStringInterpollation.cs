using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace FewMoreConcepts1
{
    public class UsingStringInterpollation
    {
        public void interpollation()
        {
           // Use string interpolation to combine a literal string and a variable value
            string firstName = "Bob";
            string message = $"Hello {firstName}";
            Console.WriteLine(message);

            //Use string interpolation with multiple variables and literal strings
            int version = 11;
            string updateText = "Update to Windows";
            string message1 = $"{updateText}{version}";
            Console.WriteLine(message1);

            //Avoid intermediate variables
            int version1 = 11;
            string updateText1 = "Update to Windows";
            Console.WriteLine($"{updateText1} {version1}!");

            //Combine verbatim literals and string interpolation
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            string projectName1 = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName1}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage1 = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage1}:\n\t\t{russianLocation}\n");



        }



    }
}
