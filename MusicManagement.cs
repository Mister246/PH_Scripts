using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagement : MonoBehaviour
{
    static public MusicManagement musicManager;
    static public AudioSource audioSource;

    // music
    public AudioClip[] musicTracks;

    void Start()
    {
        musicManager = this;
        audioSource = GetComponent<AudioSource>();
    }

    static public void PlayMusic(string trackName)
    {
        audioSource.clip = musicManager.GetMusicTrack(trackName);
        audioSource.Play();
    }

    public AudioClip GetMusicTrack(string trackName)
    {
        foreach (AudioClip music in musicTracks)
        {
            if (music.name == trackName) return music;
        }

        Debug.Log($"ERROR: Unable to find music track {trackName}");
        return null;
    }
}
