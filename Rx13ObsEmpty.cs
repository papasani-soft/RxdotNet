using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx13ObsEmpty
    {
        public static void Main(string[] args)
        {
            var empty = Observable.Empty<string>("value");
            //Behaviorally equivalent to
            var subject = new ReplaySubject<string>();
            empty.Subscribe(Console.WriteLine);
            subject.OnCompleted();
            Console.Read();
        }
    }
}
