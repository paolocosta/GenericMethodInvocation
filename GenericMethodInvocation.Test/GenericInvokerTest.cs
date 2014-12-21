using NUnit.Framework;
using System;

namespace GenericMethodInvocation.Test
{

    class Foo
    {
        public static bool Called { get; set; }
        
        public int Sum(int x,int y){
            return x + y;
        }

        public void Void()
        {
            Called = true;
        }
    }

    public class GenericInvokerTest
    {
        GenericInvoker<Foo> _sut;
        
        [SetUp]
        public void SetUp(){
            _sut = new GenericInvoker<Foo>();
        }

        [Test]
        public void Call_should_return_the_same_result_of_the_target_method()
        {
            var i = _sut.Call(x => x.Sum(2, 3));
            Assert.AreEqual(i, 5);
        }

        [Test]
        public void Calling_CallVoid_should_invoke_the_method_on_the_target_instance()
        {
            Foo.Called = false;
            _sut.CallVoid(x => x.Void());
            Assert.IsTrue(Foo.Called);
        }
    }
}
