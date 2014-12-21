using System;

namespace GenericMethodInvocation
{
    public class GenericInvoker<T1> where T1 : new()
    {
        public TResult Call<TResult>(Func<T1, TResult> function)
        {
            var t = function((new T1()));
            return t;
        }

        public void CallVoid(Action<T1> function)
        {
            function(new T1());
        }
    }
}
