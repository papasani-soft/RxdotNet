using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx5
    {
        public  static void ReplaySubjectBufferExample()
        {
            var bufferSize = 2;
            var subject = new ReplaySubject<string>(bufferSize);
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("d");
        }
        public static void Main(string[] args)
        {
            ReplaySubjectBufferExample();
            Console.Read();
        }
    }
}
