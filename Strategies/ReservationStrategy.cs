using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelManagement
{
    public class ReservationStrategy : IStrategy<Reservation>
    { 
        public void Delete(int Id)
        {
            var dbContext = DatabaseConfig.GetInstance();

            var guestToDelete = dbContext.Reservations.Find(Id);

            if (guestToDelete != null)
            {
                dbContext.Reservations.Remove(guestToDelete);
                dbContext.SaveChanges();
            }
        }

        public void Insert(Reservation Data)
        {
            var dbContext = DatabaseConfig.GetInstance();

            dbContext.Reservations.Add(Data);
            dbContext.SaveChanges();
        }

        public List<Reservation> Read()
        {
            var dbContext = DatabaseConfig.GetInstance().Reservations;

            List<Reservation> reservations = dbContext.ToList();

            return reservations;
        }

        public Reservation ReadById(string Id)
        {
            var dbContext = DatabaseConfig.GetInstance().Reservations;

            var reservation = dbContext.Find(Id);

            if (reservation != null)
            {
                return reservation;
            }

            return null;
        }

        public void Update(int Id, Reservation Data)
        {
            var dbContext = DatabaseConfig.GetInstance();

            var reservationToUpdate = dbContext.Reservations.Find(Id);

            if (reservationToUpdate != null)
            {
                dbContext.Reservations.Update(reservationToUpdate);
                dbContext.SaveChanges();
            }
        }
    }
}