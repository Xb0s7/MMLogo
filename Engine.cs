using System;
using System.Text;
using mmLogo.Contracts;
using mmLogo.Models;

namespace mmLogo
{
    public class Engine
    {
        private IDrawable drawer;
        public Engine()
        {
            drawer = new LogoDraw();
        }
        public void Run()
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(drawer.Draw(size));
        }
    }
}
