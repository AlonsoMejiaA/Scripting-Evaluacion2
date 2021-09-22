using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class EventCaller : ScriptableObject
{
    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();
    //public bool pausa =false;
    public event UnityAction _pausa;
    public event UnityAction _curso;

    public void Pausa() {
      //  pausa = true;
        _pausa?.Invoke();
    }
    public void Curso() {
        //pausa = false;
        _curso?.Invoke();
    }

}
