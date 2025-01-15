using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DeleteShop : MonoBehaviour
{
    [SerializeField] private float Timer = 20f;
    [SerializeField] private TextMeshProUGUI ShopTimerText;
    private SpawnShop SpawnShop = null;

    void Update()
    {
        Timer = Timer - Time.deltaTime;
        ShopTimerText.text = "Time left: " + Mathf.RoundToInt(Timer);
        if (Timer <= 0)
        {
            SpawnShop.IsShopSpawned = false;
            Destroy(gameObject);
        }
    }

    public void SetSpawnShop(SpawnShop spawnShop)
    {
        SpawnShop = spawnShop;
    }
}
