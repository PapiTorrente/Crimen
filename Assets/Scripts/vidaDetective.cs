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
    public Sprite corazonVacio;
    private int vidaReal;
    public static double vida;
    private bool haMuerto;
    public GameObject gameOver;
    public static int puedePerderVida = 1;

    void Start() {
        haMuerto = false;
        vida = 10;
        //Este código hace que el jugador tenga 20 puntos de vida, que se representan como 10 corazones completos.
        corazones = Vida.GetComponentsInChildren<Image>();
        gameOver.SetActive(false);
    }

    void Update() {
        actualizarCorazones();
        if(vida <= 0 && !haMuerto) {
            haMuerto = true;
            StartCoroutine(EjecutaMuerte());
        }
    }

    public void tomarDaño(double Daño) {
        if(vida >= .5 && puedePerderVida == 1) {
            puedePerderVida = 0;
            vida -= Daño;
        }
        Debug.Log("Vida: " + vida);
    }

    void actualizarCorazones() {
        for(int i = 0; i < corazones.Length; i++){
            if(vida >= i + 1){
                corazones[i].sprite = corazonCompleto;
            } else if(vida >= i + 0.5f) {
                corazones[i].sprite = corazonMitad;
            } else {
                corazones[i].sprite = corazonVacio;
            }
        }
    }

    IEnumerator EjecutaMuerte() {
        yield return new WaitForSeconds(1f);
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
