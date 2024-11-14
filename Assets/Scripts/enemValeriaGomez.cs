using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemValeriaGomez : MonoBehaviour
{
    public static double vida = 60;
    public float frecAtaque = 1f, tiempoSigAtaque = 0, iniciaConteo;
    public bool estaUsandoArma = false;
    public double dañoEnemigo, dañoBase = 4, dañoConArma = 3;

    void Start() {
        vida = 60;
        frecAtaque = 1f;
        tiempoSigAtaque = 0;
        dañoBase = 4;
        dañoConArma = 3;
    }

    void Update() {
        if(tiempoSigAtaque > 0) {
            tiempoSigAtaque -= Time.deltaTime;
        } else {
            tiempoSigAtaque = 0;
            vidaDetective.puedePerderVida = 1;
        }

        if(vida <= 0) {
            Destroy(gameObject);
        }
    }

    private double hacerDaño() {
        if(!estaUsandoArma) {
            return dañoBase; //Daño puño a puño.
        } else {
            return dañoConArma;
        }
    }

    private void OnTriggerEnter2D(Collider2D obj) {
        if(obj.tag == "Player") {
            if(tiempoSigAtaque == 0) {
                tiempoSigAtaque = frecAtaque;
                dañoEnemigo = hacerDaño();
                obj.transform.GetComponentInChildren<vidaDetective>().tomarDaño(dañoEnemigo);
            }
        }
    }

    public void tomarDaño(float Daño) {
        vida -= Daño;
    }
}
