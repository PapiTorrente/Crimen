using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaDetective : MonoBehaviour
{
    public Transform Vida;
    public Image[] corazones;
    public Sprite corazonCompleto;
    public Sprite corazonMitad;
    public static double vida;
    private bool haMuerto;
    public static int puedePerderVida = 1;

    void Start() {
        haMuerto = false;
        vida = 20;
        //gameOver.SetActive(false);
        corazones = Vida.GetComponentsInChildren<Image>();


    }

    void Update() {
    }

    public void tomarDaño(double Daño) {
        if(vida >= .5 && puedePerderVida == 1) {
            puedePerderVida = 0;
            vida -= Daño;
            actualizarCorazones();
            Debug.Log("Vida: " + vida);
        }
        if(vida <= 0 && !haMuerto) {
            haMuerto = true;
            StartCoroutine(EjecutaMuerte());
        }
    }

    void actualizarCorazones() { //Arreglar. No actualiza los corazones.
        //Debug.Log("Actualizando uwu");
        for(int i = 0; i < corazones.Length; i++){
            if(vida >= i + 1){
                corazones[i].sprite = corazonCompleto;
            } else if(vida >= i + 0.5f) {
                corazones[i].sprite = corazonMitad;
            }
        }
    }

    IEnumerator EjecutaMuerte() {
        yield return new WaitForSeconds(1.5f);
        //gameOver.SetActive(true);
    }
}
