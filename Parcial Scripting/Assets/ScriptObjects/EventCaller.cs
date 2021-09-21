using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EventCaller : ScriptableObject
{
    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();
}
