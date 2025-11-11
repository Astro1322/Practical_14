using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Первая программы с инструментами
             */
            Console.WriteLine("Первая программа: ");
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
            foreach (Instrument instrument in band)
            {
                instrument.Play();
            }
            /*
             * Вторая программа с Сообщениями
             */
            Console.WriteLine("\nВторая программа: ");
            Message[] messages = { new Message(), new Email(), new SMS() };
            foreach (Message message in messages)
            {
                message.Sand();
            }
            /*
             * Третья программа с едой
             */
            Console.WriteLine("\nТретья программа: ");
            Food[] launch = { new Pizza(), new Burger(), new Food() };
            foreach (Food f in launch)
            {
                f.Eat();
            }
            /*
            * Четвёртая программа с фигурами
            */
            Console.WriteLine("\nЧетвёртый программа: ");
            Shape[] shapes = { new Circle(), new Tringle() };
            foreach (Shape s in shapes)
            {
                Console.WriteLine($"{s.Draw()}");
            }
            /*
             * Пятая программа с игроком
             */
            Console.WriteLine("\nПятая программа: ");
            Player[] players = { new Player(), new Warrior(), new Archer() };
            foreach (Player player in players)
            {
                player.Attack();
            }
            Console.ReadLine();
        }
    }
     /*
     * Первая программа с инструментами
     */
    class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Играет музыка");
        }
    }
    class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Брень");
        }
    }
    class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Бум");
        }
    }
    /*
     * Вторая программа с Сообщениями
     */
    class Message
    {
        public virtual void Sand()
        {
            Console.WriteLine("Сообщение отправлено!");
        }
    }
    class Email : Message
    {
        public override void Sand()
        {
            Console.WriteLine("Email отправлен");
        }
    }
    class SMS : Message
    {
        public override void Sand()
        {
            Console.WriteLine("SMS отправлен");
        }
    }
    /*
     * Третья программа с едой
     */
    class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }
    class Pizza : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу");
        }
    }
    class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургЭр");
        }
    }
     /*
     * Четвёртая программа с фигурами
     */
    abstract class Shape
    {
        public abstract string Draw();
    }
    class Circle : Shape
    {
        public override string Draw()
        {
            return "Рисую круг";
        }
    }
    class Tringle : Shape
    {
        public override string Draw()
        {
            return "Рисую треугольник";
        }
    }
    /*
    * Пятая программа с фигурами
    */
    class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую");
        }
    }
    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом");
        }
    }
    class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука");
        }
    }
}
