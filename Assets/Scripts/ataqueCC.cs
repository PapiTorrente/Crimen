using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataqueCC : MonoBehaviour
{
    public float dañoGolpe = 2f;
    
    void OnTriggerEnter2D(Collider2D colisionador) {
            if(colisionador.CompareTag("Enemigo")) {
                colisionador.transform.GetComponent<enemGuardaespaldas>().tomarDaño(dañoGolpe);
                colisionador.transform.GetComponent<enemPoliciaMalo>().tomarDaño(dañoGolpe);
                colisionador.transform.GetComponent<enemCarlosNavarro>().tomarDaño(dañoGolpe);
                colisionador.transform.GetComponent<enemValeriaGomez>().tomarDaño(dañoGolpe);
            }
        }
}
