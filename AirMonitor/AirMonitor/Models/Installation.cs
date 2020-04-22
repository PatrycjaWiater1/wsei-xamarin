﻿using Android.Locations;
using Newtonsoft.Json;

namespace AirMonitor.Models
{
    public class Installation
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public Address Address { get; set; }
        public double Elevation { get; set; }
        [JsonProperty(PropertyName = "airly")]
        public bool IsAirlyInstallation { get; set; }
    }
}
