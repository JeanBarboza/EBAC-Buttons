using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;


    public void Start()
    {
        if(audioSource != null)
        {
            audioSource.Play();
        }
    }
}
