using System;
using System.ComponentModel;

namespace PROG7312_POE.Class.Models.Enums
{
 //-------------------------------------------------------------------------------------
        /// <summary>
        /// All the Possible Locations a Customer can report a Request From
        /// </summary>
    public enum SouthAfricanCities
    {
        [Description("Select Your Location")]
        None = 0,

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Northern Cape
        /// </summary>
        [Description("Kimberley")]
        Kimberley,
        [Description("Upington")]
        Upington,
        [Description("Springbok")]
        Springbok,
        [Description("Kuruman")]
        Kuruman,
        [Description("De Aar")]
        DeAar,
        [Description("Sutherland")]
        Sutherland,
        [Description("Kathu")]
        Kathu,
        [Description("Postmasburg")]
        Postmasburg,
        [Description("Warrenton")]
        Warrenton,
        [Description("Griquatown")]
        Griquatown,


        
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// North West
        /// </summary>
        [Description("Klerksdorp")]
        Klerksdorp,
        [Description("Potchefstroom")]
        Potchefstroom,
        [Description("Orkney")]
        Orkney,
        [Description("Stilfontein")]
        Stilfontein,
        [Description("Mafeking")]
        Mafeking,
        [Description("Mmabatho")]
        Mmabatho,
        [Description("Lichtenburg")]
        Lichtenburg,
        [Description("Zeerust")]
        Zeerust,
        [Description("Brits")]
        Brits,
        [Description("Hartbeespoort")]
        Hartbeespoort,
        [Description("Koster")]
        Koster,
        [Description("Mogwase")]
        Mogwase,
        [Description("Rustenburg")]
        Rustenburg,
        [Description("Amalia")]
        Amalia,
        [Description("Bray")]
        Bray,
        [Description("Ganyesa")]
        Ganyesa,
        [Description("Mareetsane")]
        Mareetsane,
        [Description("Morokweng")]
        Morokweng,
        [Description("Reivilo")]
        Reivilo,
        [Description("Schweizer Reneke")]
        SchweizerReneke,
        [Description("Taung")]
        Taung,
        [Description("Vryburg")]
        Vryburg,

        
         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Mpumalanga
        /// </summary>
        [Description("Mbombela")]
        Mbombela,
        [Description("Belfast")]
        Belfast,
        [Description("Witbank")]
        Witbank,
        [Description("Bethal")]
        Bethal,
        [Description("Barberton")]
        Barberton,
        [Description("White River")]
        WhiteRiver,
        [Description("Lydenburg")]
        Lydenburg,
        [Description("Secunda")]
        Secunda,
        [Description("Middelburg")]
        Middelburg,

        
         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Limpopo
        /// </summary>
        [Description("Polokwane")]
        Polokwane,
        [Description("Mokopane")]
        Mokopane,
        [Description("Tzaneen")]
        Tzaneen,
        [Description("Musina")]
        Musina,
        [Description("Phalaborwa")]
        Phalaborwa,
        [Description("Makhado")]
        Makhado,
        [Description("Lephalale")]
        Lephalale,
        [Description("Giyani")]
        Giyani,
        [Description("Bela Bela")]
        BelaBela,
        [Description("Modimolle")]
        Modimolle,

        // 
         //-------------------------------------------------------------------------------------
        /// <summary>
        /// KwaZulu-Natal
        /// </summary>
        [Description("Durban")]
        Durban,
        [Description("Pietermaritzburg")]
        Pietermaritzburg,
        [Description("Howick")]
        Howick,
        [Description("Hilton")]
        Hilton,
        [Description("Ballito")]
        Ballito,
        [Description("KwaDukuza")]
        KwaDukuza,
        [Description("Mandeni")]
        Mandeni,
        [Description("Kokstad")]
        Kokstad,
        [Description("Umzimkulu")]
        Umzimkulu,
        [Description("Underberg")]
        Underberg,
        [Description("Amanzimtoti")]
        Amanzimtoti,
        [Description("Pinetown")]
        Pinetown,
        [Description("Umhlanga")]
        Umhlanga,
        [Description("Isipingo")]
        Isipingo,
        [Description("Newcastle")]
        Newcastle,
        [Description("Madadeni")]
        Madadeni,
        [Description("Dannhauser")]
        Dannhauser,

        
         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Gauteng
        /// </summary>
        [Description("Krugersdorp")]
        Krugersdorp,
        [Description("Randfontein")]
        Randfontein,
        [Description("Carletonville")]
        Carletonville,
        [Description("Vanderbijlpark")]
        Vanderbijlpark,
        [Description("Vereeniging")]
        Vereeniging,
        [Description("Sebokeng")]
        Sebokeng,
        [Description("Pretoria")]
        Pretoria,
        [Description("Centurion")]
        Centurion,
        [Description("Mamelodi")]
        Mamelodi,
        [Description("Soshanguve")]
        Soshanguve,
        [Description("Atteridgeville")]
        Atteridgeville,
        [Description("Alberton")]
        Alberton,
        [Description("Benoni")]
        Benoni,
        [Description("Boksburg")]
        Boksburg,
        [Description("Germiston")]
        Germiston,
        [Description("Springs")]
        Springs,
        [Description("Kempton Park")]
        KemptonPark,
        [Description("Johannesburg")]
        Johannesburg,
        [Description("Soweto")]
        Soweto,
        [Description("Roodepoort")]
        Roodepoort,
        [Description("Randburg")]
        Randburg,

        
         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Free State
        /// </summary>
        [Description("Bloemfontein")]
        Bloemfontein,
        [Description("Botshabelo")]
        Botshabelo,
        [Description("Dewetsdorp")]
        Dewetsdorp,
        [Description("Fauresmith")]
        Fauresmith,
        [Description("Kroonstad")]
        Kroonstad,
        [Description("Sasolburg")]
        Sasolburg,
        [Description("Parys")]
        Parys,
        [Description("Allanridge")]
        Allanridge,
        [Description("Welkom")]
        Welkom,
        [Description("Virginia")]
        Virginia,
        [Description("Boshof")]
        Boshof,
        [Description("Bethlehem")]
        Bethlehem,
        [Description("Clarens")]
        Clarens,
        [Description("Ficksburg")]
        Ficksburg,
        [Description("Harrismith")]
        Harrismith,
        [Description("Ladybrand")]
        Ladybrand,
        [Description("Reitz")]
        Reitz,
        [Description("Senekal")]
        Senekal,

        
         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Eastern Cape
        /// </summary>
        [Description("Alice")]
        Alice,
        [Description("Bhisho")]
        Bhisho,
        [Description("Burgersdorp")]
        Burgersdorp,
        [Description("Cacadu")]
        Cacadu,
        [Description("Cradock")]
        Cradock,
        [Description("East London")]
        EastLondon,
        [Description("Makhanda (Grahamstown)")]
        Makhanda,
        [Description("Queenstown")]
        Queenstown,
        [Description("Gqeberha (Port Elizabeth)")]
        Gqeberha,
        [Description("Uitenhage")]
        Uitenhage,
        [Description("Port Alfred")]
        PortAlfred,
        [Description("Jeffrey's Bay")]
        JeffreysBay,
        [Description("Mthatha")]
        Mthatha,
        [Description("Stutterheim")]
        Stutterheim,
        [Description("Dutywa")]
        Dutywa,
        [Description("Ngcobo")]
        Ngcobo,
        [Description("Komga")]
        Komga,
        [Description("Fort Beaufort")]
        FortBeaufort,
        [Description("Mount Ayliff")]
        MountAyliff,
        [Description("Mount Frere")]
        MountFrere,
        [Description("Cofimvaba")]
        Cofimvaba,
        [Description("Wesleyville")]
        Wesleyville,
        [Description("Zwelitsha")]
        Zwelitsha,
        [Description("Port St. John's")]
        PortStJohns,
        [Description("Willowvale")]
        Willowvale,

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Western Cape
        /// </summary>
        [Description("Piketberg")]
        Piketberg,
        [Description("Plettenberg Bay")]
        PlettenbergBay,
        [Description("Swellendam")]
        Swellendam,
        [Description("Vredenburg")]
        Vredenburg,
        [Description("Hermanus")]
        Hermanus,
        [Description("Wellington")]
        Wellington,
        [Description("Caledon")]
        Caledon,
        [Description("Tulbagh")]
        Tulbagh,
        [Description("Cape Town")]
        CapeTown,
        [Description("Stellenbosch")]
        Stellenbosch,
        [Description("George")]
        George,
        [Description("Knysna")]
        Knysna,
        [Description("Mossel Bay")]
        MosselBay,
        [Description("Paternoster")]
        Paternoster,
        [Description("Paarl")]
        Paarl,
        [Description("Ceres")]
        Ceres,
        [Description("Worcester")]
        Worcester

    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//