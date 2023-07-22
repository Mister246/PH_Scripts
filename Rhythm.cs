using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhythm : MonoBehaviour
{
    public bool opportunity;
    public float opportunityWindow;
    public float bpm;
    public float timeBetweenBeats;

    void Start()
    {
        opportunity = false;
        opportunityWindow = 0.08f;
        bpm = 120f;
        timeBetweenBeats = 60f / bpm;
        StartCoroutine(ExecuteRhythm(timeBetweenBeats));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && opportunity)
        {
            NoteHit();
        }    
        else if (Input.GetKeyDown(KeyCode.Mouse0) && !opportunity)
        {
            NoteMiss();
        }
    }

    public IEnumerator ExecuteRhythm(float timeBetweenBeats)
    {
        yield return new WaitForSeconds(timeBetweenBeats - opportunityWindow);
        opportunity = true;

        yield return new WaitForSeconds(opportunityWindow);
        AudioManager.audioSource.pitch = Random.Range(0.95f, 1.05f);
        AudioManager.audioSource.Play();

        yield return new WaitForSeconds(opportunityWindow);
        opportunity = false;
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
