using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class.Models.Enums
{
    using System;
    using System.Collections.Generic;

    namespace PROG7312_POE.Class.Models.Enums
    {
        public class SouthAfricanCityCoordinates
        {
            public readonly SortedDictionary<SouthAfricanCities, (double Latitude, double Longitude)> Coordinates = new()
        {
            // Eastern Cape
            { SouthAfricanCities.Butterworth, (-32.3266, 28.1505) },
            { SouthAfricanCities.Dikeni, (-32.7944, 26.6289) }, // Alternative: Alice
            { SouthAfricanCities.EastLondon, (-33.0292, 27.8546) },
            { SouthAfricanCities.Gqeberha, (-33.9611, 25.6144) }, // Formerly Port Elizabeth
            { SouthAfricanCities.GraaffReinet, (-32.2529, 24.5302) },
            { SouthAfricanCities.Kariega, (-33.7592, 25.3884) }, // Formerly Uitenhage
            { SouthAfricanCities.Komani, (-31.8976, 26.8778) }, // Formerly Queenstown
            { SouthAfricanCities.Makhanda, (-33.3102, 26.5321) }, // Formerly Grahamstown
            { SouthAfricanCities.Mthatha, (-31.5889, 28.7844) },
            { SouthAfricanCities.Qonce, (-32.8824, 27.3941) }, // Formerly King William's Town
            { SouthAfricanCities.Zwelitsha, (-32.8895, 27.4423) },

            // Free State
            { SouthAfricanCities.Bethlehem, (-28.2300, 28.3000) },
            { SouthAfricanCities.Bloemfontein, (-29.0852, 26.1596) },
            { SouthAfricanCities.Jagersfontein, (-29.7631, 25.4311) },
            { SouthAfricanCities.Kroonstad, (-27.6500, 27.2333) },
            { SouthAfricanCities.Odendaalsrus, (-27.8711, 26.6928) },
            { SouthAfricanCities.Parys, (-26.9023, 27.4566) },
            { SouthAfricanCities.Phuthaditjhaba, (-28.5353, 28.8159) },
            { SouthAfricanCities.Sasolburg, (-26.8136, 27.8164) },
            { SouthAfricanCities.Virginia, (-28.1039, 26.8654) },
            { SouthAfricanCities.Welkom, (-27.9864, 26.7060) },

            // Gauteng
            { SouthAfricanCities.Benoni, (-26.1889, 28.3206) },
            { SouthAfricanCities.Boksburg, (-26.2123, 28.2594) },
            { SouthAfricanCities.Brakpan, (-26.2353, 28.3695) },
            { SouthAfricanCities.Carletonville, (-26.3603, 27.3975) },
            { SouthAfricanCities.Germiston, (-26.2250, 28.1761) },
            { SouthAfricanCities.Johannesburg, (-26.2041, 28.0473) },
            { SouthAfricanCities.Krugersdorp, (-26.0954, 27.8026) },
            { SouthAfricanCities.Pretoria, (-25.7479, 28.2293) },
            { SouthAfricanCities.Randburg, (-26.0936, 28.0017) },
            { SouthAfricanCities.Randfontein, (-26.1667, 27.7000) },
            { SouthAfricanCities.Roodepoort, (-26.1625, 27.8725) },
            { SouthAfricanCities.Soweto, (-26.2485, 27.8546) },
            { SouthAfricanCities.Springs, (-26.2527, 28.4424) },
            { SouthAfricanCities.Vanderbijlpark, (-26.7064, 27.8377) },
            { SouthAfricanCities.Vereeniging, (-26.6731, 27.9261) },

            // KwaZulu-Natal
            { SouthAfricanCities.Durban, (-29.8587, 31.0218) },
            { SouthAfricanCities.Empangeni, (-28.7552, 31.8936) },
            { SouthAfricanCities.Newcastle, (-27.7535, 29.9318) },
            { SouthAfricanCities.Pietermaritzburg, (-29.6168, 30.3928) },
            { SouthAfricanCities.Pinetown, (-29.8184, 30.8510) },
            { SouthAfricanCities.Ulundi, (-28.3358, 31.4166) },
            { SouthAfricanCities.Umlazi, (-29.9220, 30.8850) },
            { SouthAfricanCities.uMnambithi, (-28.5542, 29.7852) }, // Ladysmith

            // Limpopo
            { SouthAfricanCities.Giyani, (-23.3000, 30.7170) },
            { SouthAfricanCities.Lebowakgomo, (-24.2000, 29.5000) },
            { SouthAfricanCities.Musina, (-22.3525, 30.0399) },
            { SouthAfricanCities.Phalaborwa, (-23.9430, 31.1411) },
            { SouthAfricanCities.Polokwane, (-23.9045, 29.4689) },
            { SouthAfricanCities.Seshego, (-23.8667, 29.4000) },
            { SouthAfricanCities.Sibasa, (-22.9500, 30.4833) },
            { SouthAfricanCities.Thabazimbi, (-24.5914, 27.4110) },

            // Mpumalanga
            { SouthAfricanCities.Emalahleni, (-25.8770, 29.2093) }, // Formerly Witbank
            { SouthAfricanCities.Mbombela, (-25.4691, 30.9802) }, // Formerly Nelspruit
            { SouthAfricanCities.Secunda, (-26.5167, 29.1667) },

            // North West
            { SouthAfricanCities.Klerksdorp, (-26.8521, 26.6667) },
            { SouthAfricanCities.Mahikeng, (-25.8636, 25.6440) },
            { SouthAfricanCities.Mmabatho, (-25.8500, 25.6333) },
            { SouthAfricanCities.Potchefstroom, (-26.7147, 27.0970) },
            { SouthAfricanCities.Rustenburg, (-25.6676, 27.2421) },

            // Northern Cape
            { SouthAfricanCities.Kimberley, (-28.7383, 24.7637) },
            { SouthAfricanCities.Kuruman, (-27.4524, 23.4325) },
            { SouthAfricanCities.PortNolloth, (-29.2500, 16.8667) },

            // Western Cape
            { SouthAfricanCities.Bellville, (-33.9024, 18.6261) },
            { SouthAfricanCities.CapeTown, (-33.9249, 18.4241) },
            { SouthAfricanCities.Constantia, (-34.0211, 18.4297) },
            { SouthAfricanCities.George, (-33.9646, 22.4590) },
            { SouthAfricanCities.Hopefield, (-33.0667, 18.3500) },
            { SouthAfricanCities.Oudtshoorn, (-33.5906, 22.2010) },
            { SouthAfricanCities.Paarl, (-33.7342, 18.9621) },
            { SouthAfricanCities.SimonsTown, (-34.1931, 18.4327) },
            { SouthAfricanCities.Stellenbosch, (-33.9346, 18.8668) },
            { SouthAfricanCities.Swellendam, (-34.0241, 20.4401) },
            { SouthAfricanCities.Worcester, (-33.6461, 19.4485) }
        };

            // Method to get the coordinates of a given SouthAfricanCities enum
            public (double Latitude, double Longitude) GetCityCoordinates(SouthAfricanCities city)
            {
                // Check if the city is in the dictionary and return the coordinates
                if (Coordinates.TryGetValue(city, out var coordinates))
                {
                    return coordinates;
                }
                else
                {
                    throw new ArgumentException("City not found in the coordinates dictionary", nameof(city));
                }
            }
        }
    }

}
