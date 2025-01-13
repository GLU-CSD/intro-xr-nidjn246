using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnShop : MonoBehaviour
{
    [SerializeField] private GameObject Shop;
    [SerializeField] private GameObject Spawnlocation;
    [SerializeField] InputActionReference Buttonclick;
    void Start()
    {
        
    }

    void Update()
    {
        if (Buttonclick != null)
        {
            Debug.Log("hij werkt");
        }
    }
}
