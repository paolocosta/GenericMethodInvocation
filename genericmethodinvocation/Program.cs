using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodInvocation
{
    class Program//gzhgzgzuguzgzbhbhbhjbhjhhh
    {
        static void Main(string[] args)
        {
            int sum = new GenericInvoker<UserManager>().Call(x => x.Sum(2, 3));
            new GenericInvoker<UserManager>().CallVoid(x => x.Message(sum.ToString()));
            System.Console.ReadLine();
        }
    }
}
