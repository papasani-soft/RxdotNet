using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx9
    {
        public static void Main(string[] args)
        {
            var values = new Subject<int>();
            values.Subscribe(
            value => Console.WriteLine("1st subscription received {0}", value),
            ex => Console.WriteLine("Caught an exception : {0}", ex));
            values.OnNext(0);
            values.OnError(new Exception("Dummy exception"));
            Console.Read();
        }
    }
}
