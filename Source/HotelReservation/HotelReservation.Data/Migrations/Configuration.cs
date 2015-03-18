namespace HotelReservation.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HotelReservation.Data.HotelReservationDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HotelReservation.Data.HotelReservationDataContext context)
        {
            context.Facilities.AddOrUpdate(
                p => p.FacilityDesc,
                new Facility() { FacilityDesc = "Idd telephones" },
                new Facility() { FacilityDesc = "Tv with satellite channels" },
                new Facility() { FacilityDesc = "Mini-bar" },
                new Facility() { FacilityDesc = "Jacuzzi (suites and luxury rooms only)" },
                new Facility() { FacilityDesc = "free toiletries" },
                new Facility() { FacilityDesc = "In-room safe deposit box" },
                new Facility() { FacilityDesc = "Laundry service" },
                new Facility() { FacilityDesc = "24-hour room service" },
                new Facility() { FacilityDesc = "Tea/coffee facilities" }
                );


            context.RoomTypes.AddOrUpdate(
               p => p.RoomTypeDesc,
                new RoomType() { RoomTypeDesc = "Standard"},
                new RoomType() { RoomTypeDesc = "Deluxe"},
                new RoomType() { RoomTypeDesc = "Premium"},
                new RoomType() { RoomTypeDesc = "Luxury Family Rooms"},
                new RoomType() { RoomTypeDesc = "Luxury Suite"},
                new RoomType() { RoomTypeDesc = "Mountbatten Suite"}
               );

            context.RoomBands.AddOrUpdate(
              p => p.RoomBandDesc,
               new RoomBand() { RoomBandDesc = "Single" },
               new RoomBand() { RoomBandDesc = "Double" },
               new RoomBand() { RoomBandDesc = "Triple" }
              );

            //Random rnd = new Random();

            ////int roomType = rnd.Next(1, 7);

            //for (int i = 0; i < 100; i++)
            //{
            //    int roomType = rnd.Next(1, 7);
            //    var room = new Room() { AdditionalNotes = i.ToString(), RoomTypeID = roomType };
            //    context.Rooms.Add(room);
            //}

            //context.SaveChanges();

        }
    }
}
