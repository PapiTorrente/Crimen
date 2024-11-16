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
    private Vector4 colorDaño = new Vector4(1.0f, 0.564705882f, 0.564705882f, 1.0f);
    private Vector4 colorNoDaño = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
    public SpriteRenderer jugador;
    private float reestablecerSprite = 0.5f;
    public AudioSource sonidoVida;

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

        if(reestablecerSprite > 0) {
            reestablecerSprite -= Time.deltaTime;
        } else {
            reestablecerSprite = 0;
            jugador.color = new Color(colorNoDaño.x, colorNoDaño.y, colorNoDaño.z, colorNoDaño.w);
        }
    }

    public void tomarDaño(double Daño) {
        if(vida >= .5 && puedePerderVida == 1) {
            puedePerderVida = 0;
            vida -= Daño;
            sonidoVida.Play();
            jugador.color = new Color(colorDaño.x, colorDaño.y, colorDaño.z, colorDaño.w);
            reestablecerSprite = 0.5f;
        }
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
