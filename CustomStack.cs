using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    class StackException : Exception
    {
        public StackException(String Message) : base(Message)
        {

        }


    }

    public class Validate
    {
        public static void create()
        {

            Stack<int> objStack = new Stack<int>();
            objStack.Push(10);
            objStack.Push(20);
            objStack.Push(30);
            objStack.Push(40);
            objStack.Push(50);



            Console.WriteLine("{0},{1},{2},{3}", objStack.Pop(), objStack.Pop(), objStack.Pop(), objStack.Pop());

            if (objStack.Count() == 0)
            {
                throw new StackException("No More Elments IN Stack => Stack Is Empty:");
            }
        }

    }

    class CustomStack
    {
        public static void Main(string[] args)
        {


            try
            {
                Validate.create();

            }
            catch (StackException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }

    }
}
