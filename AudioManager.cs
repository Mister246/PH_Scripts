using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}