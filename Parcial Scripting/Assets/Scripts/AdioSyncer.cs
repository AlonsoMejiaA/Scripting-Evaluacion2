using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdioSyncer : MonoBehaviour
{

    [SerializeField] AudioSource Reproductor;

    public float bias;
    public float timeStep;
    public float timeToBeat;
    public float restSmoothTime;

    public float previousAudioValue;
    public float audioValue;
    private float timer;

    protected bool beating;

    private void Update()
    {

        OnUpdate();
        
    }

   public virtual void OnUpdate()
    {

        previousAudioValue = audioValue;
        audioValue = AudioSpectrum.spectrumValue;

        if (previousAudioValue > bias && audioValue <= bias)
        {
            if(timer>timeStep)
            {
                OnBeat();
            }
        }

        timer += Time.deltaTime;

    }

    public virtual void OnBeat()
    {
        Debug.Log("beat");
        timer = 0;
        beating = true;
    }



}
