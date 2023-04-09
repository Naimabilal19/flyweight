using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
     abstract class milirarybase
    {
        public string pic;
        public int speed;
        public int power;
        public int pos;
        public milirarybase() { }
        public abstract void Show(int pos);
    }
    class lightinfantry: milirarybase
    {
        public lightinfantry()
        {
            pic = "light fantry.jpg";
            speed = 20;
            power = 10;
        }
       
        public override void Show(int pos)
        {
            this.pos = pos;
            Console.WriteLine($"Type: {pic}\nSpeed: {speed}\nPower: {power}\nPosition: {this.pos}");
        }
    }
    class vehicle : milirarybase
    {
        public vehicle()
        {
            pic = "vehicle.jpg";
            speed = 70;
            power = 0;
        }
        public override void Show(int pos)
        {
            this.pos = pos;
            Console.WriteLine($"Type: {pic}\nSpeed: {speed}\nPower: {power}\nPosition: {this.pos}");
        }
    }
    class heavyground : milirarybase
    {
        public heavyground()
        {
            pic = "heavy ground.jpg";
            speed = 15;
            power = 150;
        }
        public override void Show(int pos)
        {
            this.pos = pos;
            Console.WriteLine($"Type: {pic}\nSpeed: {speed}\nPower: {power}\nPosition: {this.pos}");
        }
    }
    class lightground : milirarybase
    {
        public lightground()
        {
            pic = "light ground.jpg";
            speed = 50;
            power = 30;
        }
        public override void Show(int pos)
        {
            this.pos = pos;
            Console.WriteLine($"Type: {pic}\nSpeed: {speed}\nPower: {power}\nPosition: {this.pos}");
        }
    }
    class air : milirarybase
    {
        public air()
        {
            pic = "air.jpg";
            speed = 300;
            power = 100;
        }
        public override void Show(int pos)
        {
            this.pos = pos;
            Console.WriteLine($"Type: {pic}\nSpeed: {speed}\nPower: {power}\nPosition: {this.pos}");
        }
    }

    public class MilitaryBaseFactory
    {
        List<Tuple<lightinfantry, string>> Arr = new List<Tuple<lightinfantry, string>>();
        public MilitaryBaseFactory(params milirarybase[] MB)
        {
            foreach (var i in MB)
            {
                Arr(new Tuple<lightinfantry, string>(new lightinfantry(), i.pic));
            }
        }
        public void Show()
        {
            var Score = Arr.Count;
            Console.WriteLine("\n" + $"{Score}");
            foreach (var i in Arr)
            {
                Console.WriteLine(i.Item2);
            }
        }
    }
        class Program
        {
                static void Main(string[] args)
                {
                    
                }

        }
}
