using HotelManagement.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Observer
{
    public class ReservationSubject : ISubject
    {
        private string? action { get; set; } = null;
        private List<Reservation>? reservations { get; set; }

        private List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify(string action, Object obj)
        {
            this.action = action;
            this.reservations = (List<Reservation>) obj;
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public List<Reservation> Reservations => reservations;
        public string Action => action;
    }
}
