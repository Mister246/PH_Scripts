using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManagement : MonoBehaviour
{
    static public AudioSource audioSource;

    // sound effects:
    public AudioClip genericBeat;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayGenericBeat()
    {
        audioSource.PlayOneShot(genericBeat);
    }
}
