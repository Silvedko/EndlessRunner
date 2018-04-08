using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WeatherController : MonoBehaviour
{
    public static event Action<Weather> OnWeatherChanged;

    public Weather CurrentWeather
    {
        get { return _currentWEather; }
        private set
        {
            if (_currentWEather != value)
            {                
                _currentWEather = value;
                OnWeatherChanged?.Invoke(value);
            }
        }
    }
    private Weather _currentWEather;

    void Start()
    {

    }

    void Update()
    {

    }
}

public enum Weather
{
    Sunny,
    Rain,
    Snowy
}
