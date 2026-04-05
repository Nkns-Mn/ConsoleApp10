using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestInfo info = new TestInfo("山田",20,170,60);
            info.ShowPerson();
            info.ShowInfo();
        }
    }
    class TestPerson //基底クラス・名前・年齢
    {
        public string name { get; set; }
        public int age { get; set; }
        public TestPerson (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void ShowPerson()
        {
            Console.WriteLine("基底クラス");
            Console.WriteLine($"名前：{name},年齢：{age}");
        }
        }

    class TestInfo : TestPerson　//派生クラス・身長・体重
    {
        public int height { get; set; }
        public int weight { get; set; }
        public TestInfo(string name, int age, int height, int weight)
           : base(name, age)
        {
            this.height = height;
            this.weight = weight;
        }
        public void ShowInfo()
        {
            Console.WriteLine("派生クラス");
            Console.WriteLine($"身長：{height},体重：{weight}");
        }
    }
}
