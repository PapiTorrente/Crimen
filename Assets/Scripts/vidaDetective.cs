using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaDetective : MonoBehaviour
{
    public static double vida;

    private bool haMuerto;

    public static int puedePerderVida = 1;
    void Start() {
        haMuerto = false;
        vida = 20;
        //gameOver.SetActive(false);
    }

    void Update() {
        
    }

    public void tomarDaño(double Daño) {
        if(vida >= .5 && puedePerderVida == 1) {
            puedePerderVida = 0;
            vida -= Daño;
        }
        if(vida <= 0 && !haMuerto) {
            haMuerto = true;
            StartCoroutine(EjecutaMuerte());
        }
    }

    IEnumerator EjecutaMuerte() {
        yield return new WaitForSeconds(1.5f);
        //gameOver.SetActive(true);
    }
}
