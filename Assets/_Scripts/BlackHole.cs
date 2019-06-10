using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlackHoles"))
        {
            GetComponent<SphereCollider>().isTrigger = true;
        }
    }
}
