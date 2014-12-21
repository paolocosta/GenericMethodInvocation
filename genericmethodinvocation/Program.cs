namespace GenericMethodInvocation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = new GenericInvoker<UserManager>().Call(x => x.Sum(2, 3));
            new GenericInvoker<UserManager>().CallVoid(x => x.Message(sum.ToString()));
            System.Console.ReadLine();
        }
    }
}
