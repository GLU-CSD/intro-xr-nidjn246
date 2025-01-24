using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    public void HardMode()
    {
        SceneManager.LoadScene("Hard");
    }

    public void NormalMode()
    {
        SceneManager.LoadScene("Normal");
    }
}
