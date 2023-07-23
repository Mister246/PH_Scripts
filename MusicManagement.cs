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
        PlayMusic("Get Down Funk");
    }

    static public void PlayMusic(string trackName)
    {
        AudioClip GetMusicTrack(string trackName)
        {
            foreach (AudioClip music in musicManager.musicTracks)
            {
                if (music.name == trackName) return music;
            }

            Debug.Log($"ERROR: Unable to find music track {trackName}");
            return null;
        }

        audioSource.clip = GetMusicTrack(trackName);
        audioSource.Play();
    }
}
