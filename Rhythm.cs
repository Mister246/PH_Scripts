using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhythm : MonoBehaviour
{
    public float bpm;
    public float timeBetweenBeats;

    void Start()
    {
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
