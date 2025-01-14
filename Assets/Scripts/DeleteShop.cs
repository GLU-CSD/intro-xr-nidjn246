using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DeleteShop : MonoBehaviour
{
    [SerializeField] private float Timer = 20f;
    [SerializeField] private TextMeshProUGUI ShopTimer;
    private GameObject ScoreHand;

    private void Awake()
    {
        ScoreHand = GameObject.Find("ScoreHand");
    }
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        ShopTimer.text = "Time left: " + Mathf.RoundToInt(Timer);
        if (Timer <= 0)
        {
             ScoreHand.GetComponent<SpawnShop>().IsShopSpawned = false;
            Destroy(gameObject);
        }
    }
}
