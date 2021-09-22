using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnpausaState : IReproductorState
{   
    public void Ejecutar(Reproductor reproductor) {
        reproductor.GetComponent<AudioSource>().Pause();
    }

   
}
