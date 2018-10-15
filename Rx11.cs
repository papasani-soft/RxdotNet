using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx11
    {
        public static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("Completed"));
            subject.OnCompleted();
            subject.OnNext(2);
            Console.Read();
        }
    }
}
