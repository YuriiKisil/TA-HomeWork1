using System;

namespace TA_2_Intefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Keyboard k = new Keyboard();
            Mouse m = new Mouse();
            Joystick J = new Joystick();
            k.GetInput();
            m.GetInput();
            J.GetInput();
            Console.WriteLine("Hello World!");
        }
    }

    interface IInput
    {
        void GetInput();
    }
    public class Keyboard:IInput
    {
       public void GetInput()
        {
            Console.WriteLine("Keyboard"); 
        }
    }
    public class Mouse : IInput
    {
        public void GetInput()
        {
            Console.WriteLine("Mouse");
        }
    }
    public class Joystick : IInput
    {
        public void GetInput()
        {
            Console.WriteLine("Joystick");
        }
    }

}
