/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb webClient = new HtmlWeb();
            var doc = webClient.Load("http://10.0.2.213/config.html");
            var node = doc.DocumentNode.SelectSingleNode("//body/pre");
            //string pre = node.InnerText;

            Console.WriteLine(node.InnerText);

            // string bodyToCounter= new String(pre.Where(Char.IsDigit).ToArray());



            Console.ReadKey();
        }


    }
}

*/