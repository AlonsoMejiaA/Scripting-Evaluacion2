using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class EventCaller : ScriptableObject
{
    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();
    //public bool pausa =false;
    public event UnityAction _pause;
    public event UnityAction _resume;

    public void Pause() {
      //  pausa = true;
        _pause?.Invoke();
    }
    public void Resume() {
        //pausa = false;
        _resume?.Invoke();
    }

}
