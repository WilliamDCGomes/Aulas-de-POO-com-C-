using System;
using ProcessFile.Entities.Exceptions;
namespace ProcessFile.Entities {
    class Reservation {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {
        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
            if (checkOut <= checkIn) {
                throw new DomanException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;
            string error = null;
            if(checkIn < now || checkOut < now) {
                throw new DomanException("Reservation dates for update must be future dates");
            }
            if(checkOut <= checkIn) {
                throw new DomanException("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            return $"Room {RoomNumber}, check-in: {CheckIn:dd/MM/yyyy}, check-out: {CheckOut:dd/MM/yyyy}, {Duration()} nights";
        }
    }
}
