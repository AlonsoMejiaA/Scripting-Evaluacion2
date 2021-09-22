using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class EventCaller : ScriptableObject
{
    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();
    public bool pausa =false;
    public event UnityAction<bool> _pausa;

    public void Pausa() {
        pausa = true;
        _pausa?.Invoke(pausa);
    }
    public void Nopausa() {
        pausa = false;
        _pausa.Invoke(pausa);
    }

}
