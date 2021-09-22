using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour {
    [SerializeField] EventCaller eventos;
    [SerializeField] GameObject encurso;

    private void Awake() {
        eventos._pausa += Aparecer;
        eventos._curso += Desaparecer;
       
        encurso.SetActive(false);
    }

    void Aparecer() {
        encurso.SetActive(true);
    }
    void Desaparecer() {
        encurso.SetActive(false);
    }
}
