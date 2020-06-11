using AirMonitor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
