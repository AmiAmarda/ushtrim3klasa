using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerEnter(Collider other)
    {
        //ndryshimi i pozicionit te lojtarit
        other.transform.position = teleportPoint.position;
    }
}

