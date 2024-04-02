using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Observer
{
    public class RoomSubject : ISubject
    {
        private string? action { get; set; } = null;
        private List<Room>? rooms { get; set; }

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
            this.rooms = (List<Room>) obj;
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public List<Room> Rooms => rooms;
        public string Action => action;
    }
}
