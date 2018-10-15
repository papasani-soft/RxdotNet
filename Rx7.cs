using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace rxdotNet
{
    class Rx7
    {
        //public static void BehaviorSubjectExample()
        //{
        //    //Need to provide a default value.
        //    var subject = new BehaviorSubject<string>("a");
        //    subject.Subscribe(Console.WriteLine);
        //}
        //public static void BehaviorSubjectExample()
        //{
        //    var subject = new BehaviorSubject<string>("a");
        //    subject.OnNext("b");
        //    subject.Subscribe(Console.WriteLine);
        //}
        //public static void BehaviorSubjectExample()
        //{
        //    var subject = new BehaviorSubject<string>("a");
        //    subject.OnNext("b");
        //    subject.Subscribe(Console.WriteLine);
        //    subject.OnNext("c");
        //    subject.OnNext("d");
        //}
        public static void BehaviorSubjectExample()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
            subject.Subscribe(Console.WriteLine);
        }
        public static void Main(string[] args)
        {
            BehaviorSubjectExample();
            Console.Read();
        }
    }
}
