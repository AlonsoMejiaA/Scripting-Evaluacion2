using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncursoState : IReproductorState {
    public void Ejecutar(Reproductor reproductor) {
        reproductor.GetComponent<AudioSource>().Play();
    }
}
