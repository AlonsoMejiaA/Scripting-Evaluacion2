using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{  
    public AudioSource audio;
    IReproductorState estado;
    [SerializeField]EventCaller eventos;

    private void Awake() {
        audio = GetComponent<AudioSource>();      
    }
    private void OnEnable() {
        eventos._pausa += PararCancion;
        eventos._curso += ReproducirCancion;
    }
    private void OnDisable() {
        eventos._pausa -= PararCancion;
        eventos._curso -= ReproducirCancion;
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
