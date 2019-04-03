using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;

    public bool continuous;

    public void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    private void UpdateContinuous()
    {
        const float degreesPerHour = 30f;
        const float degreesPerMinute = 6f;
        const float degreesPerSecond = 6f;

        var now = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = Quaternion.Euler(0f, (float)now.TotalHours * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, (float)now.TotalMinutes * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, (float)now.TotalSeconds * degreesPerSecond, 0f);
    }

    private void UpdateDiscrete()
    {
        const float degreesPerHour = 30f;
        const float degreesPerMinute = 6f;
        const float degreesPerSecond = 6f;

        DateTime now = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, now.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, now.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, now.Second * degreesPerSecond, 0f);
    }
}
