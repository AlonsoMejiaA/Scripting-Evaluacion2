using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour {
    [SerializeField] EventCaller events;
    [SerializeField] GameObject oncourse;

    private void Awake() {
        events._pause += Aparecer;
        events._resume += Desaparecer;
       
        oncourse.SetActive(false);
    }

    void Aparecer() {
        oncourse.SetActive(true);
    }
    void Desaparecer() {
        oncourse.SetActive(false);
    }
}
