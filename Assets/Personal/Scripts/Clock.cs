using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Clock : MonoBehaviour
{
    [Header("Hour, min, sec")]
    [SerializeField] private Transform[] ck; //h,m,s
    void Update()
    
    {
        DateTime dt = DateTime.Now;
        ck[0].transform.rotation = Quaternion.Euler(360/12*-dt.Hour+90, 0, 90);
        ck[1].transform.rotation = Quaternion.Euler(360 / 60 * -dt.Minute+90, 0, 90);
        ck[2].transform.rotation = Quaternion.Euler(360 / 60 * -dt.Second+90, 0, 90);
    }
}
