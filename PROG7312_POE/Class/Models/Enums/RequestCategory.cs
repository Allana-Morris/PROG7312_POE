using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class.Models.Enums
{
     //-------------------------------------------------------------------------------------
        /// <summary>
        /// Contains all the Categories the Customer can file a Request Under 
        /// </summary>
    public enum RequestCategory
    {
        [Description("Select a Category")]
        None = 0,

        [Description("Water and Sanitation")]
        WaterSanitation,

        [Description("Electricity and Loadshedding")]
        ElectricityLoadshedding,

        [Description("Roads and Potholes")]
        RoadsPotholes,

        [Description("Waste Management")]
        WasteManagement,

        [Description("Public Transport")]
        PublicTransport,

        [Description("Community Safety and Security")]
        CommunitySafetySecurity,

        [Description("Parks and Public Spaces")]
        ParksPublicSpaces,

        [Description("Housing")]
        Housing,

        [Description("Noise Complaints")]
        NoiseComplaints,

        [Description("Environmental Health")]
        EnvironmentalHealth,

        [Description("Traffic and Transport Infrastructure")]
        TrafficTransportInfrastructure,

        [Description("Animal Control and Wildlife")]
        AnimalControlWildlife
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//