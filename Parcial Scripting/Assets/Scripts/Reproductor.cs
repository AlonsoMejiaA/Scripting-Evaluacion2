using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{
    public AudioSource audio;
    IReproductorState estado;

    private void Awake() {
        audio = GetComponent<AudioSource>();
    }
    private void Start() {
        estado = new EncursoState();
        estado.Ejecutar(this);
    }
    public void ReproducirCancion() {
        estado = new EncursoState();
        estado.Ejecutar(this);
    }

    public void PararCancion() {
        estado = new EnpausaState();
        estado.Ejecutar(this);
    }
    
}
