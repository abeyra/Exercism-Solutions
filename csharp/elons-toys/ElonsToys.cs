using System;
using System.Runtime.CompilerServices;

public class RemoteControlCar
{
    private int _distanceDriven;
    private int _batteryPercentage = 100;
    private bool _isBatteryEmpty => _batteryPercentage == 0;
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() => _isBatteryEmpty ? "Battery empty" : $"Battery at {_batteryPercentage}%";

    public void Drive()
    {
        if (_isBatteryEmpty) return;

        _distanceDriven += 20;
        _batteryPercentage -= 1;
    }
        
}
