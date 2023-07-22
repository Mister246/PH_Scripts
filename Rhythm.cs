using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhythm : MonoBehaviour
{
    static public bool opportunity;
    public float opportunityWindow;
    public float bpm;
    public float timeBetweenBeats;

    void Start()
    {
        opportunity = false;
        opportunityWindow = 0.16f;
        bpm = 120f;
        timeBetweenBeats = 60f / bpm;
    }

    static public void NoteHit()
    {
        Debug.Log("Note Hit!");
    }

    static public void NoteMiss()
    {
        Debug.Log("Note Missed!");
    }
}
