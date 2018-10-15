using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx6
    {
        public static void ReplaySubjectWindowExample()
        {
            var window = TimeSpan.FromMilliseconds(150);
            var subject = new ReplaySubject<string>(window);
            subject.OnNext("w");
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            subject.OnNext("x");
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            subject.OnNext("y");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("z");
        }
        public static void Main(string[] args)
        {
            ReplaySubjectWindowExample();
            Console.Read();
        }
    }
}
