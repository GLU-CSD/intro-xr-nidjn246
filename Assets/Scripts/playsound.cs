using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSlap;
    [SerializeField] private AudioSource audioHeal;
    public void playSlapSound()
    {
        if (audioSlap != null)
        {
            audioSlap.Play();
        }
    }

    public void playHealSound()
    {
        if (audioHeal != null)
        {
            audioHeal.Play();
        }
    }
}
