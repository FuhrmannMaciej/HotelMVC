using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HotelMVC.Data;
using System;
using System.Linq;

namespace HotelMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HotelMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HotelMVCContext>>()))
            {
                if (context.Hotel.Any())
                {
                    return;
                }

                context.Hotel.AddRange(
                    new Hotel
                    {
                        HotelName = "Grand Hotel",
                        Size = Hotel.HotelSize.Enormous,
                        NumberOfFreeRooms = 367,
                        RoomPrice = 890,
                        FoundedIn = "1854",
                        VIPs = true
                    },

                    new Hotel
                    {
                        HotelName = "Hotel Delta",
                        Size = Hotel.HotelSize.Medium,
                        NumberOfFreeRooms = 125,
                        RoomPrice = 450,
                        FoundedIn = "1915",
                        VIPs = false
                    },

                    new Hotel
                    {
                        HotelName = "The Langham",
                        Size = Hotel.HotelSize.Big,
                        NumberOfFreeRooms = 289,
                        RoomPrice = 750,
                        FoundedIn = "1900",
                        VIPs = true
                    },

                    new Hotel
                    {
                        HotelName = "Primland Resort",
                        Size = Hotel.HotelSize.Big,
                        NumberOfFreeRooms = 321,
                        RoomPrice = 779,
                        FoundedIn = "2000",
                        VIPs = true
                    },
                    new Hotel
                    {
                        HotelName = "Hotel Rad",
                        Size = Hotel.HotelSize.Small,
                        NumberOfFreeRooms = 40,
                        RoomPrice = 240,
                        FoundedIn = "2005",
                        VIPs = false
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
