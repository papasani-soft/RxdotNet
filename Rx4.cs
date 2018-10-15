using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx4
    {
        static void Main(string[] args)
        {
           // var subject = new Subject<string>();
            var subject = new ReplaySubject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            Console.ReadKey();
        }
        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            //The next two lines are equivalent.
            //sequence.Subscribe(value=>Console.WriteLine(value));
            sequence.Subscribe(Console.WriteLine);
        }
       
    }
}
