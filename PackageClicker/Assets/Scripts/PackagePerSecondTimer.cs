using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackagePerSecondTimer : MonoBehaviour
{
    public float TimerDuration = 1f;

    public double PackagePerSecond { get; set; }

    private float _counter;

    private void Update()
    {
        _counter += Time.deltaTime;

        if (_counter >= TimerDuration)
        {
            PackageManager.instance.SimplePackageIncrease(PackagePerSecond);

            _counter = 0;
        }
    }
}
