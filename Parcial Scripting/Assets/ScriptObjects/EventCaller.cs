using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class EventCaller : ScriptableObject
{
    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();
    public AudioClip songToPlay;
    public event UnityAction<AudioClip> songChanged;
    //public bool pausa =false;
    public event UnityAction _pause;
    public event UnityAction _resume;

    //not repeating song
    public AudioClip currentSong;

     void Awake()
    {
        currentSong = audioClips[Random.Range(0, audioClips.Capacity)];
    }

    public void Pause() {
      //  pausa = true;
        _pause?.Invoke();
    }
    public void Resume() {
        //pausa = false;
        _resume?.Invoke();
    }
    public void songChange()
    {
        
        songToPlay = audioClips[Random.Range(0, audioClips.Capacity)];
        if (songToPlay.name == currentSong.name)
        {
            songChange();
        }
        else
        {
            currentSong = songToPlay;
            songChanged.Invoke(songToPlay);
        }
        
    }
}
