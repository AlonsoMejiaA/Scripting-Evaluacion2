using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{

    float[] audioSpectrum;
    public static float spectrumValue { get; private set; }

    private void Start()
    {
        audioSpectrum = new float[128];
    }

    private void Update()
    {
        AudioListener.GetSpectrumData(audioSpectrum, 0, FFTWindow.Rectangular);

        if (audioSpectrum != null && audioSpectrum.Length > 0)
        {
            spectrumValue = audioSpectrum[0] * 50;
        }
        

    }




}
