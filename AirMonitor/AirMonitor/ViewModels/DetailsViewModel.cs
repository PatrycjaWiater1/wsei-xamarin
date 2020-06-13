using AirMonitor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    public class DetailsViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;

        public DetailsViewModel() { }

        public DetailsViewModel(INavigation navigation, Installation installation)
        {
            _navigation = navigation;
            CaqiValue = Convert.ToInt32(installation.Measurement.Current.Indexes.FirstOrDefault().Value);
            Pm25Value = Convert.ToInt32(installation.Measurement.Current.Values.FirstOrDefault(x => x.Name == "PM25").Value);
            Pm10Value = Convert.ToInt32(installation.Measurement.Current.Values.FirstOrDefault(x => x.Name == "PM10").Value);
            Humidity = Convert.ToInt32(installation.Measurement.Current.Values.FirstOrDefault(x => x.Name == "HUMIDITY").Value);
            Pressure = Convert.ToInt32(installation.Measurement.Current.Values.FirstOrDefault(x => x.Name == "PRESSURE").Value);
            Description = installation.Measurement.Current.Indexes.FirstOrDefault().Description;
            Advice = installation.Measurement.Current.Indexes.FirstOrDefault().Advice;
        }
        private int _caqiValue;
        public int CaqiValue
        {
            get => _caqiValue;
            set => SetProperty(ref _caqiValue, value);
        }

        private int _pm25Value;
        public int Pm25Value
        {
            get => _pm25Value;
            set => SetProperty(ref _pm25Value, value);
        }

        private int _pm10Value;
        public int Pm10Value
        {
            get => _pm10Value;
            set => SetProperty(ref _pm10Value, value);
        }

        private int _humidity;
        public int Humidity
        {
            get => _humidity;
            set => SetProperty(ref _humidity, value);
        }

        private int _pressure;
        public int Pressure
        {
            get => _pressure;
            set => SetProperty(ref _pressure, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _advidce;
        public string Advice
        {
            get => _advidce;
            set => SetProperty(ref _advidce, value);
        }
    }
}
