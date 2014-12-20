using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void call_method_check_correct_result()
        {
            var i = _sut.Call(x => x.Sum(2, 3));
            Assert.AreEqual(i, 5);
        }

        [Test]
        public void call_void_method_check_it_was_called()
        {
            Foo.Called = false;
            _sut.CallVoid(x => x.Void());
            Assert.IsTrue(Foo.Called);
        }
    }
}
