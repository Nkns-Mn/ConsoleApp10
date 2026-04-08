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
        public string Name { get; set; }
        public int Age { get; set; }
        public TestPerson (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void ShowPerson()
        {
            Console.WriteLine("基底クラス");
            Console.WriteLine($"名前：{Name},年齢：{Age}");
        }
        }

    class TestInfo : TestPerson //派生クラス・身長・体重
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public TestInfo(string name, int age, int height, int weight)
           : base(name, age)
        {
            this.Height = height;
            this.Weight = weight;
        }
        public void ShowInfo()
        {
            Console.WriteLine("派生クラス");
            Console.WriteLine($"身長：{Height},体重：{Weight}");
        }
    }
}
