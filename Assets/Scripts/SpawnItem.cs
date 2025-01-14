using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnItem : MonoBehaviour
{
    [SerializeField] private GameObject itemToSpawn;
    [SerializeField] private GameObject Spawnlocation;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private int Price = 0 ;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public void SpawnBoughtItem()
    {
        if (gameManager.score > Price)
        {
            gameManager.score -= Price;
            Instantiate(itemToSpawn, Spawnlocation.transform.position, Quaternion.identity);
        }
    }
}
