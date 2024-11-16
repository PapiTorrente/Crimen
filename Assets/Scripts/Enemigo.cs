using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public double vida;
    public float frecAtaque, tiempoSigAtaque, iniciaConteo;
    public bool estaUsandoArma = false;
    public double dañoEnemigo, dañoBase, dañoConArma;

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
