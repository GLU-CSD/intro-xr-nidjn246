using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomtrigger : MonoBehaviour
{
    [SerializeField] private Light mushroomLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Geef de XR Rig de tag "Player"
        {
            mushroomLight.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mushroomLight.enabled = false;
        }
    }
}
