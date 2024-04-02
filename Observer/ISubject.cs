using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Observer
{
    public interface ISubject
    {
        string Action { get; }
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(string action, Object obj);
    }
}
