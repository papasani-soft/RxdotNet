using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Disposables;

namespace rxdotNet
{
    //public class NumbersObservable : IObservable<int>
    //{
    //    private readonly int _amount;
    //    public NumbersObservable(int amount)
    //    {
    //        _amount = amount;
    //    }
    //    public IDisposable Subscribe(IObserver<int> observer)
    //    {
    //        for (int i = 0; i < _amount; i++)
    //        {
    //            observer.OnNext(i);
    //        }
    //        observer.OnCompleted();
    //        return Disposable.Empty;
    //    }
    //}
    public class ConsoleObserver<T> : IObserver<T>
    {
        private readonly string _name;
        public ConsoleObserver(string name = "")
        {
            _name = name;
        }
        public void OnNext(T value)
        {
            Console.WriteLine("{0} - OnNext({1})", _name, value);
        }
        public void OnError(Exception error)
        {
            Console.WriteLine("{0} - OnError:", _name);
            Console.WriteLine("\t {0}", error);
        }
        public void OnCompleted()
        {
            Console.WriteLine("{0} - OnCompleted()", _name);
        }
    }
}
