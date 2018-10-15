using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx16BlockMethod
    {
        private  static IObservable<string> BlockingMethod()
        {
            var subject = new ReplaySubject<string>();
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnCompleted();
            Thread.Sleep(1000);
            return subject;
        }
        public static void Main(string[] args)
        {
            BlockingMethod();
        }
    }
}
