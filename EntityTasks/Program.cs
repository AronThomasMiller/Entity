using EntityTasks.Models;
using System;
using System.Linq;

namespace EntityTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Get All hotels from DB
            //var context = new HotelContext();
            //var hotel = context.Hotels.ToList();
            //foreach (var item in hotel)
            //{
            //    Console.WriteLine(item.Id + item.HotelName);
            //}

            //Update first hotel foundation year from existing value to 1937
            //using (var context = new HotelContext())
            //{
            //    var hotel = context.Hotels.First<Hotel>();
            //    hotel.CreationYear = 1937;
            //    context.SaveChanges();
            //}

            //Delete 3d hotel from DB by Id
            //var context = new HotelContext();
            //var hotel = context.Hotels.Where(x => x.Id == 3).FirstOrDefault();
            //context.Hotels.Remove(hotel);

            //Get all users which name starts from "A"
            //var context = new HotelContext();
            //var client = context.InfoClients.Where(x => x.ClientName.ToCharArray()[0] == 'A').ToList();
            //foreach (var item in client)
            //{
            //    Console.WriteLine(item.ClientName + item.Id);
            //}

            //Select All rooms from DB sorted by Price
            //var context = new HotelContext();
            //var hotelRoom = context.HotelRooms.OrderBy(x =>x.Price).ToList();
            //foreach (var item in hotelRoom)
            //{
            //    Console.WriteLine($"{item.Id} {item.Price} {item.RoomNumber}");
            //}

            //Select All rooms from DB that belong to 'Edelweiss' hotel and sorted by price
            //using (HotelContext context = new HotelContext())
            //{
            //    var neestedQuery = from s in context.Hotels
            //                       join c in context.HotelRooms on s.Id equals c.HotelId
            //                       where s.HotelName == "Edelweiss"
            //                       orderby c.Price
            //                       select new
            //                       {
            //                           c.Id,
            //                           c.RoomNumber,
            //                           c.Price

            //                       };
            //    foreach (var item in neestedQuery)
            //    {
            //        Console.WriteLine($"{item.Id} {item.Price} {item.RoomNumber}");
            //    }
            //}

            //Select Hotels that have rooms with comfort level 3
            //using (HotelContext context = new HotelContext())
            //{
            //    var neestedQuery = from s in context.Hotels
            //                       join c in context.HotelRooms on s.Id equals c.HotelId
            //                       where c.ComfortLvl == 3
            //                       select new
            //                       {
            //                           c.Id,
            //                           c.RoomNumber,
            //                           c.ComfortLvl

            //                       };
            //    foreach (var item in neestedQuery)
            //    {
            //        Console.WriteLine($"{item.Id} {item.ComfortLvl} {item.RoomNumber}");
            //    }
            //}

            //Select Hotelname and room number for rooms that have comfort level 1
            //using (HotelContext context = new HotelContext())
            //{
            //    var neestedQuery = from s in context.Hotels
            //                       join c in context.HotelRooms on s.Id equals c.HotelId
            //                       where c.ComfortLvl == 1
            //                       select new
            //                       {
            //                           s.HotelName,
            //                           c.RoomNumber,
            //                           c.ComfortLvl
            //                       };
            //    foreach (var item in neestedQuery)
            //    {
            //        Console.WriteLine($"{item.HotelName} {item.ComfortLvl} {item.RoomNumber}");
            //    }
            //}

            //TO DO:
            //Select Hotel names and count of hotel rooms
            //using (HotelContext context = new HotelContext())
            //{
            //    var neestedQuery = context.Hotels.Select(c => new {
            //        HotelName = c.HotelName,
            //        RoomsCount = context.HotelRooms.Where(s => s.HotelId == c.Id).Count()
            //    }).GroupBy(c => c.HotelName);

            //    foreach (var v in neestedQuery)
            //    {
            //        var res = v.First();
            //        Console.WriteLine(res.HotelName + " " + res.RoomsCount);
            //    }
            //}

            // Select Username, room number, reservation period.
            //using (HotelContext context = new HotelContext())
            //{
            //    var neestedQuery = from s in context.Bookings
            //                       join c in context.HotelRooms on s.HotelRoomId equals c.Id
            //                       join a in context.InfoClients on s.HotelRoomId equals a.Id
            //                       select new
            //                       {
            //                           s.BookingEndDay,
            //                           s.BookingStartDay,
            //                           c.RoomNumber,
            //                           a.ClientName
            //                       };
            //    foreach (var item in neestedQuery)
            //    {
            //        Console.WriteLine($"{item.BookingEndDay} {item.BookingStartDay} {item.RoomNumber} {item.ClientName}");
            //    }
            //}



            ////////////////////////////
            //////////BOOKING //////////
            ////////////////////////////



            //using (var context = new HotelContext())
            //{
            //    var booking = new Booking()
            //    {
            //        ClientId = 1,
            //        HotelRoomId = 1,
            //        BookingStartDay = new DateTime(2019, 05, 01),
            //        BookingEndDay = new DateTime(2019, 05, 04)
            //    };
            //    context.Bookings.Add(booking);
            //    context.SaveChanges();
            //}



            ////////////////////////////
            ///////////HOTEL ///////////
            ////////////////////////////



            //using (var context = new HotelContext())
            //{
            //    var hotel = new Hotel()
            //    {
            //        HotelName = "Fox",
            //        CreationYear = 2019,
            //        HotelAddress = "Golovna 1",
            //        IsActive = true
            //    };
            //    context.Hotels.Add(hotel);
            //    context.SaveChanges();
            //}



            ////////////////////////////
            //////////HOTELROOM ////////
            ////////////////////////////



            //using (var context = new HotelContext())
            //{
            //    var hotelRomm = new HotelRoom()
            //    {
            //        HotelId = 1,
            //        RoomNumber = 101,
            //        Price = 2100,
            //        ComfortLvl = 3,
            //        Capability = 4
            //    };

            //    context.HotelRooms.Add(hotelRomm);
            //    context.SaveChanges();
            //}



            ////////////////////////////
            ////////INFO CLIENT ////////
            ////////////////////////////



            //using (var context = new HotelContext())
            //    {
            //        var info = new InfoClient()
            //        {
            //            ClientName = "Michael",
            //            Email = "Michael@gmail.com",
            //        };
            //        context.InfoClients.Add(info);
            //        context.SaveChanges();
            //    }
            //}
        }
    }
}