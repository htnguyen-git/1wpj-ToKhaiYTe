using HtmlAgilityPack;
using System;
using System.Linq;
using System.Text;

namespace ToolCrawList
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"INSERT INTO [dbo].[Gate]([GateName],[IsPublished],[IsDeleted])VALUES";

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            var doc = new HtmlDocument();
            doc.DetectEncodingAndLoad(@"C:\Users\tfoso\source\repos\1wpj-ToKhaiYTe\ToolCrawList\CuaKhau.html");

            var listCuaKhau = doc.DocumentNode.SelectNodes("//select[@id='input25096']/option");

            foreach (var item in listCuaKhau.ToList())
            {
                s += $"(N'{item.InnerText}',1,0),";
            }

            Console.WriteLine(s.Substring(0,s.Length-1));
            
        }
    }
}
