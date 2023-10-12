using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Rritja e fortesise se kercimit
        other.GetComponent<Jump>().jumpStrength = 10;

    }

    void OnTriggerExit(Collider other)
    {
        //Reduktimi i fortesise se kercimit
        other.GetComponent<Jump>().jumpStrength = 2;

    }
}
