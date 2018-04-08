using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    Vector3 _lastPoint;

    public Vector3 GetNextPoint()
    {
        return Vector3.zero;
    }

    private void Start()
    {
        WeatherController.OnWeatherChanged += OnWeatherChanged;

    }

    private void OnWeatherChanged (Weather obj)
    {
        switch (obj)
        {
            case Weather.Rain:
                break;
            default:
                break;
        }
    }

    private RoadTile GenerateNextTile ()
    {
        //var randWidth = Random.Range();

        RoadTile tmpTile = new RoadTile();
        return tmpTile;
    }


    void Update()
    {

    }
}

public struct RoadTile
{
    float Width;
    float Length;
    bool IsLeftTurn;

    public RoadTile (float width, float length, bool isLeft)
    {
        Width = width;
        Length = length;
        IsLeftTurn = isLeft;
    }
}

