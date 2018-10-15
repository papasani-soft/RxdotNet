using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx14ObsNever
    {
        public static void Main(string[] args)
        {
            var never = Observable.Never<string>("value");
            //similar to a subject without notifications
            // var subject = new Subject<string>();
            //never.OnNext("value2");
            never.Subscribe(Console.WriteLine);
            Console.Read();
        }
    }
}
