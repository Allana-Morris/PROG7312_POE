using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PROG7312_POE.Class.Models.Enums
{
    public static class SouthAfricanProvinces
    {
        public struct CityInfo
        {
            public SouthAfricanCities City { get; }
            public string Description { get; }

            public CityInfo(SouthAfricanCities city)
            {
                City = city;
                Description = GetDescription(city);
            }

            private static string GetDescription(SouthAfricanCities city)
            {
                var field = city.GetType().GetField(city.ToString());
                var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
                return attribute?.Description ?? city.ToString();
            }
        }

        public enum SouthAfricanProvince
        {
            [Description("Select a Province")]
            None,
            [Description("Western Cape")]
            WesternCape,
            [Description("Eastern Cape")]
            EasternCape,
            [Description("Northern Cape")]
            NorthernCape,
            [Description("Free State")]
            FreeState,
            [Description("Gauteng")]
            Gauteng,
            [Description("KwaZulu-Natal")]
            KwaZuluNatal,
            [Description("Limpopo")]
            Limpopo,
            [Description("Mpumalanga")]
            Mpumalanga,
            [Description("North West")]
            NorthWest
        }


        public static SortedDictionary<string, SortedSet<CityInfo>> GroupedCitiesByProvince = new()
        {
            { "Eastern Cape", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Alice),
                    new CityInfo(SouthAfricanCities.Bhisho),
                    new CityInfo(SouthAfricanCities.Burgersdorp),
                    new CityInfo(SouthAfricanCities.Cacadu),
                    new CityInfo(SouthAfricanCities.Cradock),
                    new CityInfo(SouthAfricanCities.EastLondon),
                    new CityInfo(SouthAfricanCities.Makhanda),
                    new CityInfo(SouthAfricanCities.Queenstown),
                    new CityInfo(SouthAfricanCities.Gqeberha),
                    new CityInfo(SouthAfricanCities.Uitenhage),
                    new CityInfo(SouthAfricanCities.PortAlfred),
                    new CityInfo(SouthAfricanCities.JeffreysBay),
                    new CityInfo(SouthAfricanCities.Mthatha),
                    new CityInfo(SouthAfricanCities.Stutterheim),
                    new CityInfo(SouthAfricanCities.Dutywa),
                    new CityInfo(SouthAfricanCities.Ngcobo),
                    new CityInfo(SouthAfricanCities.Komga),
                    new CityInfo(SouthAfricanCities.FortBeaufort),
                    new CityInfo(SouthAfricanCities.MountAyliff),
                    new CityInfo(SouthAfricanCities.MountFrere),
                    new CityInfo(SouthAfricanCities.Cofimvaba),
                    new CityInfo(SouthAfricanCities.Wesleyville),
                    new CityInfo(SouthAfricanCities.Zwelitsha),
                    new CityInfo(SouthAfricanCities.PortStJohns),
                    new CityInfo(SouthAfricanCities.Willowvale)
                }
            },
            { "Free State", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Bloemfontein),
                    new CityInfo(SouthAfricanCities.Botshabelo),
                    new CityInfo(SouthAfricanCities.Dewetsdorp),
                    new CityInfo(SouthAfricanCities.Fauresmith),
                    new CityInfo(SouthAfricanCities.Kroonstad),
                    new CityInfo(SouthAfricanCities.Sasolburg),
                    new CityInfo(SouthAfricanCities.Parys),
                    new CityInfo(SouthAfricanCities.Allanridge),
                    new CityInfo(SouthAfricanCities.Welkom),
                    new CityInfo(SouthAfricanCities.Virginia),
                    new CityInfo(SouthAfricanCities.Boshof),
                    new CityInfo(SouthAfricanCities.Bethlehem),
                    new CityInfo(SouthAfricanCities.Clarens),
                    new CityInfo(SouthAfricanCities.Ficksburg),
                    new CityInfo(SouthAfricanCities.Harrismith),
                    new CityInfo(SouthAfricanCities.Ladybrand),
                    new CityInfo(SouthAfricanCities.Reitz),
                    new CityInfo(SouthAfricanCities.Senekal),
            }
            },
            { "Gauteng", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Krugersdorp),
                    new CityInfo(SouthAfricanCities.Randfontein),
                    new CityInfo(SouthAfricanCities.Carletonville),
                    new CityInfo(SouthAfricanCities.Vanderbijlpark),
                    new CityInfo(SouthAfricanCities.Vereeniging),
                    new CityInfo(SouthAfricanCities.Sebokeng),
                    new CityInfo(SouthAfricanCities.Pretoria),
                    new CityInfo(SouthAfricanCities.Centurion),
                    new CityInfo(SouthAfricanCities.Mamelodi),
                    new CityInfo(SouthAfricanCities.Soshanguve),
                    new CityInfo(SouthAfricanCities.Atteridgeville),
                    new CityInfo(SouthAfricanCities.Alberton),
                    new CityInfo(SouthAfricanCities.Benoni),
                    new CityInfo(SouthAfricanCities.Boksburg),
                    new CityInfo(SouthAfricanCities.Germiston),
                    new CityInfo(SouthAfricanCities.Springs),
                    new CityInfo(SouthAfricanCities.KemptonPark),
                    new CityInfo(SouthAfricanCities.Johannesburg),
                    new CityInfo(SouthAfricanCities.Soweto),
                    new CityInfo(SouthAfricanCities.Roodepoort),
                    new CityInfo(SouthAfricanCities.Randburg),
                }
            },
            { "KwaZulu-Natal", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Durban),
                    new CityInfo(SouthAfricanCities.Pietermaritzburg),
                    new CityInfo(SouthAfricanCities.Howick),
                    new CityInfo(SouthAfricanCities.Hilton),
                    new CityInfo(SouthAfricanCities.Ballito),
                    new CityInfo(SouthAfricanCities.KwaDukuza),
                    new CityInfo(SouthAfricanCities.Mandeni),
                    new CityInfo(SouthAfricanCities.Kokstad),
                    new CityInfo(SouthAfricanCities.Umzimkulu),
                    new CityInfo(SouthAfricanCities.Underberg),
                    new CityInfo(SouthAfricanCities.Amanzimtoti),
                    new CityInfo(SouthAfricanCities.Pinetown),
                    new CityInfo(SouthAfricanCities.Umhlanga),
                    new CityInfo(SouthAfricanCities.Isipingo),
                    new CityInfo(SouthAfricanCities.Newcastle),
                    new CityInfo(SouthAfricanCities.Madadeni),
                    new CityInfo(SouthAfricanCities.Dannhauser),
                }
            },
            { "Western Cape", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Piketberg),
                    new CityInfo(SouthAfricanCities.PlettenbergBay),
                    new CityInfo(SouthAfricanCities.Swellendam),
                    new CityInfo(SouthAfricanCities.Vredenburg),
                    new CityInfo(SouthAfricanCities.Hermanus),
                    new CityInfo(SouthAfricanCities.Wellington),
                    new CityInfo(SouthAfricanCities.Caledon),
                    new CityInfo(SouthAfricanCities.Tulbagh),
                    new CityInfo(SouthAfricanCities.CapeTown),
                    new CityInfo(SouthAfricanCities.Stellenbosch),
                    new CityInfo(SouthAfricanCities.George),
                    new CityInfo(SouthAfricanCities.Knysna),
                    new CityInfo(SouthAfricanCities.MosselBay),
                    new CityInfo(SouthAfricanCities.Paternoster),
                    new CityInfo(SouthAfricanCities.Paarl),
                    new CityInfo(SouthAfricanCities.Ceres),
                    new CityInfo(SouthAfricanCities.Worcester)

                }
            },
            { "Northern Cape", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Kimberley),
                    new CityInfo(SouthAfricanCities.Upington),
                    new CityInfo(SouthAfricanCities.Springbok),
                    new CityInfo(SouthAfricanCities.Kuruman),
                    new CityInfo(SouthAfricanCities.DeAar),
                    new CityInfo(SouthAfricanCities.Sutherland),
                    new CityInfo(SouthAfricanCities.Kathu),
                    new CityInfo(SouthAfricanCities.Postmasburg),
                    new CityInfo(SouthAfricanCities.Warrenton),
                    new CityInfo(SouthAfricanCities.Griquatown)
                }
            },
            { "Limpopo", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Polokwane),
                    new CityInfo(SouthAfricanCities.Mokopane),
                    new CityInfo(SouthAfricanCities.Tzaneen),
                    new CityInfo(SouthAfricanCities.Musina),
                    new CityInfo(SouthAfricanCities.Phalaborwa),
                    new CityInfo(SouthAfricanCities.Makhado),
                    new CityInfo(SouthAfricanCities.Lephalale),
                    new CityInfo(SouthAfricanCities.Giyani),
                    new CityInfo(SouthAfricanCities.BelaBela),
                    new CityInfo(SouthAfricanCities.Modimolle)
                }
            },
            { "Mpumalanga", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Mbombela),
                    new CityInfo(SouthAfricanCities.Belfast),
                    new CityInfo(SouthAfricanCities.Witbank),
                    new CityInfo(SouthAfricanCities.Bethal),
                    new CityInfo(SouthAfricanCities.Barberton),
                    new CityInfo(SouthAfricanCities.WhiteRiver),
                    new CityInfo(SouthAfricanCities.Lydenburg),
                    new CityInfo(SouthAfricanCities.Secunda),
                    new CityInfo(SouthAfricanCities.Middelburg)
                }
            },
            { "North West", new SortedSet<CityInfo>(Comparer<CityInfo>.Create((x, y) => string.Compare(x.Description, y.Description)))
                {
                    new CityInfo(SouthAfricanCities.Klerksdorp),
                    new CityInfo(SouthAfricanCities.Potchefstroom),
                    new CityInfo(SouthAfricanCities.Orkney),
                    new CityInfo(SouthAfricanCities.Stilfontein),
                    new CityInfo(SouthAfricanCities.Mafeking),
                    new CityInfo(SouthAfricanCities.Mmabatho),
                    new CityInfo(SouthAfricanCities.Lichtenburg),
                    new CityInfo(SouthAfricanCities.Zeerust),
                    new CityInfo(SouthAfricanCities.Brits),
                    new CityInfo(SouthAfricanCities.Hartbeespoort),
                    new CityInfo(SouthAfricanCities.Koster),
                    new CityInfo(SouthAfricanCities.Mogwase),
                    new CityInfo(SouthAfricanCities.Rustenburg),
                    new CityInfo(SouthAfricanCities.Amalia),
                    new CityInfo(SouthAfricanCities.Bray),
                    new CityInfo(SouthAfricanCities.Ganyesa),
                    new CityInfo(SouthAfricanCities.Mareetsane),
                    new CityInfo(SouthAfricanCities.Morokweng),
                    new CityInfo(SouthAfricanCities.Reivilo),
                    new CityInfo(SouthAfricanCities.SchweizerReneke),
                    new CityInfo(SouthAfricanCities.Taung),
                    new CityInfo(SouthAfricanCities.Vryburg),
                }
            }
        };
    }
}
