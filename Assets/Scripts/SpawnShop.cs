using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnShop : MonoBehaviour
{
    [SerializeField] private GameObject Shop;
    [SerializeField] private GameObject Spawnlocation;
    [SerializeField] public bool IsShopSpawned;

    public void SpawnTheShop()
    {
        if (IsShopSpawned == false)
        {
        IsShopSpawned = true;
        Instantiate(Shop, Spawnlocation.transform.position, Quaternion.identity);
        }
    }
    
}
