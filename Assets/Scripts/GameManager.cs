using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit;

public class GameManager : MonoBehaviour
{
    private bool gameActive = true;
    public int score = 0;
    private float scoreTimer = 0f; // Timer om score te verhogen
    [SerializeField] private int scoreAmount;
    public GameObject xrRig;

    // UI om de score te laten zien
    [SerializeField] private TextMeshProUGUI scoreText;

    // UI die getoond wordt bij game over
    [SerializeField] private GameObject gameOverUI;

    private void Start()
    {
        scoreText.text = "Score: " + score;
    }
    void Update()
    {
        if (gameActive)
        {
            //Time.deltaTime geeft aantal seconden sinds laatste Update
            scoreTimer += Time.deltaTime;

            if (scoreTimer >= 1f) // Verhoog de score elke seconde
            {
                score = score + scoreAmount;
                scoreTimer = 0f; // Reset de timer
            }
            scoreText.text = "Score: " + score;
        }
    }

    public void GameOver()
    {
        gameActive = false;

        // Vind alle vijanden in de scene
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //Loop door alle gevonden vijanden en vernietig ze
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

        // Doe hetzelfde met de spawners
        GameObject[] spawners = GameObject.FindGameObjectsWithTag("Spawner");
        foreach (GameObject spawner in spawners)
        {
            Destroy(spawner);
        }

        Vector3 xrRigPosition = xrRig.transform.position;
        // Toon de Game Over UI
        gameOverUI.SetActive(true);
        gameOverUI.GetComponent<RectTransform>().position = xrRigPosition;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
