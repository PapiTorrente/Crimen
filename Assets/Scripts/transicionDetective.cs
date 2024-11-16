using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transicionDetective : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obj){
        if(obj.gameObject.tag == "Portal_01") { //Portal 01 a Portal 05 //Calle Izquierda Arriba
            Vector3 posicionPlayer = new Vector3(-49.08f,5.9f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_02") { //Portal 02 a Portal 14 //Calle Derecha Arriba
            Vector3 posicionPlayer = new Vector3(49.78f,5.9f,1);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_03") { //Portal 03 a Portal 06 //Calle Izquierda Abajo
            Vector3 posicionPlayer = new Vector3(-49.08f,-12.11f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_04") { //Portal 04 a Portal 15 //Calle Derecha Abajo
            Vector3 posicionPlayer = new Vector3(49.78f,-12.11f,1);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_05") { //Portal 05 a Portal 01 //Calle Playa Arriba
            Vector3 posicionPlayer = new Vector3(-19.2f,5.9f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_06") { //Portal 06 a Portal 03 //Calle Playa Abajo
            Vector3 posicionPlayer = new Vector3(-19.2f,-12.11f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_07") { //Portal 07 a Portal 08 //Calle Reversible 1
            Vector3 posicionPlayer = new Vector3(-52.89f,-18.88f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_08") { //Portal 08 a Portal 07 //Calle Reversible 2
            Vector3 posicionPlayer = new Vector3(-52.89f,17.97f,0);
            this.transform.position = posicionPlayer;
        }
        
        if(obj.gameObject.tag == "Portal_09") { //Portal 09 a Portal  //Puerta Mansion Entrar
            Vector3 posicionPlayer = new Vector3(-82.94f,-6.89f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_10") { //Portal 10 a Portal 11 //Puerta Bar Entrar
            Vector3 posicionPlayer = new Vector3(-14.88f,29f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_11") { //Portal 11 a Portal 10 //Puerta Bar Salir
            Vector3 posicionPlayer = new Vector3(-18.53f,8.48f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_12") { //Portal 12 a Portal 13 //Puerta Detective Entrar
            Vector3 posicionPlayer = new Vector3(67.54f,-40.25f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_13") { //Portal 13 a Portal 12 //Puerta Detective Salir
            Vector3 posicionPlayer = new Vector3(69.5f,-20.66f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_14") { //Portal 14 a Portal 02 //Calle Bosque Izquierda Arriba
            Vector3 posicionPlayer = new Vector3(19.8f,5.9f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_15") { //Portal 15 a Portal 04 //Cale Bosque Izquierda Abajo
            Vector3 posicionPlayer = new Vector3(19.8f,-12.11f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_16") { //Portal 16 a Portal 09 //Puerta Mansión Salir
            Vector3 posicionPlayer = new Vector3(-59.3f,-6.7f,0);
            this.transform.position = posicionPlayer;
        }
    }
}
