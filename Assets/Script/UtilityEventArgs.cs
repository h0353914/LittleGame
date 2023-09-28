using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class FireEventArgs : EventArgs
{
    public float FireDamage { get; private set; }
    public float FireForce { get; private set; }

    public FireEventArgs(float damageDate, float forceData)
    {
        FireDamage = damageDate;
        FireForce = forceData;
    }
}
