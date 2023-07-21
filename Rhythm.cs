using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhythm : MonoBehaviour
{
    public float opportunityWindow;
    public float bpm;
    public float timeBetweenBeats;

    void Start()
    {
        opportunityWindow = 0.16f;
        bpm = 120f;
        timeBetweenBeats = 60f / bpm;
        StartCoroutine(ExecuteRhythm(timeBetweenBeats));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("mouse clicked");
        }    
    }

    public IEnumerator ExecuteRhythm(float timeBetweenBeats)
    {
        yield return new WaitForSeconds(timeBetweenBeats);
        AudioManager.audioSource.pitch = Random.Range(0.95f, 1.05f);
        AudioManager.audioSource.Play();
        StartCoroutine(ExecuteRhythm(timeBetweenBeats));
    }

    public void NoteHit()
    {
        Debug.Log("Note Hit!");
    }

    public void NoteMiss()
    {
        Debug.Log("Note Missed!");
    }
}
