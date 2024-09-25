using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataques : MonoBehaviour
{
    private GameObject ControladorAtaque;
    [SerializeField] private float radioGolpe = 0.4f;
    [SerializeField] private float dañoGolpe = 2f;

    private void Update() {
        if(Input.GetButtonDown("Fire1")) {
            StartCoroutine(Golpear());
        }
    }

    IEnumerator Golpear() {
        //Colocar un if en el que determine si está usando arma o no
        //Este if también sabrá si el arma tiene balas o no, si ya no tiene balas entonces colocar
        //que estaUsandoArma sea igual a falso.

        ControladorAtaque.SetActive(true);
        yield return new WaitForSeconds(0.1f); // Duración del golpe
        ControladorAtaque.SetActive(false);
    }

}
