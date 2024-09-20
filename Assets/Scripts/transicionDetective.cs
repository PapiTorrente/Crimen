using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transicionDetective : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obj){
        if(obj.gameObject.tag == "Portal_01") {
            Vector3 posicionPlayer = new Vector3(-32.2f,5.65f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_02") {
            Vector3 posicionPlayer = new Vector3(1,1,1);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_03") {
            Vector3 posicionPlayer = new Vector3(-32.2f,-11.98f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_04") {
            Vector3 posicionPlayer = new Vector3(1,1,1);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_05") {
            Vector3 posicionPlayer = new Vector3(-19.6f,5.65f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_06") {
            Vector3 posicionPlayer = new Vector3(-19.6f,-11.98f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_07") {
            Vector3 posicionPlayer = new Vector3(-36.2f,-19.4f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_08") {
            Vector3 posicionPlayer = new Vector3(-36.2f,18.4f,0);
            this.transform.position = posicionPlayer;
        }
    }
}
