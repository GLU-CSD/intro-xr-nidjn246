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
#if UNITY_EDITOR
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnTheShop();
        }
    }
#endif
    public void SpawnTheShop()
    {
        if (IsShopSpawned == false)
        {
            IsShopSpawned = true;
            GameObject shop = Instantiate(Shop, Spawnlocation.transform.position, Spawnlocation.transform.rotation);
            DeleteShop deleteShop = shop.GetComponent<DeleteShop>();
            deleteShop.SetSpawnShop(this);
        }
    }
    
}
