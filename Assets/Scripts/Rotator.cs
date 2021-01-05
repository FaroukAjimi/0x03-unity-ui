using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        Quaternion target = Quaternion.Euler(45,0,0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 0.005F);
    }
}