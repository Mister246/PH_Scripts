using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Rhythm : MonoBehaviour
{
    public float bpm;
    private float timeBetweenBeats;
    public Intervals[] intervals;

    void Start()
    {
        bpm = 120f;
        timeBetweenBeats = 60f / bpm;
    }

    void Update()
    {
        if (MusicManagement.audioSource.isPlaying)
        // if music is playing
        {
            foreach (Intervals interval in intervals)
            {
                float sampledTime = MusicManagement.audioSource.timeSamples / (MusicManagement.audioSource.clip.frequency * interval.GetIntervalLength(bpm));
                interval.CheckForNewInterval(sampledTime);
            }
        }
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

[System.Serializable]
public class Intervals
// tutorial: https://www.youtube.com/watch?v=gIjajeyjRfE
{
    [SerializeField] private float steps;
    [SerializeField] private UnityEvent trigger;
    private int lastInterval;

    public float GetIntervalLength(float bpm)
    {
        return 60f / (bpm * steps);
    }

    public void CheckForNewInterval(float interval)
    {
        if (Mathf.FloorToInt(interval) != lastInterval)
        // if reached a new interval
        {
            lastInterval = Mathf.FloorToInt(interval);
            trigger.Invoke();
        }
    }
}