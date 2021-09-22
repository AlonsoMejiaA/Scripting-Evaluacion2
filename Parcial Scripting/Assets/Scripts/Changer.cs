using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    public EventCaller Caller;
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        Caller.songChanged += Changingsong;
    }
    private void OnDisable()
    {
        Caller.songChanged -= Changingsong;
    }
    private void Changingsong(AudioClip songToPlay)
    {
        source.clip = songToPlay;
        source.Play();
    }
}
