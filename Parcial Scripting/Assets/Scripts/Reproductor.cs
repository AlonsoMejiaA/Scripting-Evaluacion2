using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{  
    private AudioSource audio;
    IReproductorState states;
    [SerializeField]EventCaller events;

    private void Awake() {
        audio = GetComponent<AudioSource>();      
    }
    private void OnEnable() {
        events._pause += PararCancion;
        events._resume += ReproducirCancion;
    }
    private void OnDisable() {
        events._pause -= PararCancion;
        events._resume -= ReproducirCancion;
    }
    private void Start() {
        states = new EncursoState();
        states.Ejecutar(this);
    }
    public void ReproducirCancion() {
        states = new EncursoState();
        states.Ejecutar(this);
    }

    public void PararCancion() {
        states = new EnpausaState();
        states.Ejecutar(this);
    }
    
}
