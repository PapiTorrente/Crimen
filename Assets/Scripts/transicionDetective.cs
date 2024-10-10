using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transicionDetective : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obj){
        if(obj.gameObject.tag == "Portal_01") { //Portal 01 a Portal 05
            Vector3 posicionPlayer = new Vector3(-32.4f,6f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_02") { //Portal 02 a Portal 14
            Vector3 posicionPlayer = new Vector3(30.953f,5.9f,1);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_03") { //Portal 03 a Portal 06
            Vector3 posicionPlayer = new Vector3(-32.4f,-11.3f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_04") { //Portal 04 a Portal 15
            Vector3 posicionPlayer = new Vector3(30.953f,-11.2f,1);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_05") { //Portal 05 a Portal 01
            Vector3 posicionPlayer = new Vector3(-19.2f,6f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_06") { //Portal 06 a Portal 03
            Vector3 posicionPlayer = new Vector3(-19.2f,-11.3f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_07") { //Portal 07 a Portal 08
            Vector3 posicionPlayer = new Vector3(-36.2f,-18.6f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_08") { //Portal 08 a Portal 07
            Vector3 posicionPlayer = new Vector3(-36.2f,18f,0);
            this.transform.position = posicionPlayer;
        }
        
        if(obj.gameObject.tag == "Portal_09") { //Portal 09 a Portal 
            Vector3 posicionPlayer = new Vector3(-59.24f,-6.89f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_10") { //Portal 10 a Portal 11
            Vector3 posicionPlayer = new Vector3(-14.88f,29f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_11") { //Portal 11 a Portal 10
            Vector3 posicionPlayer = new Vector3(-18.53f,8.48f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_12") { //Portal 12 a Portal 13
            Vector3 posicionPlayer = new Vector3(49.5494f,-34.4f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_13") { //Portal 13 a Portal 12
            Vector3 posicionPlayer = new Vector3(50.9218f,-20.78f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_14") { //Portal 14 a Portal 02
            Vector3 posicionPlayer = new Vector3(20.09f,5.9f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_15") { //Portal 14 a Portal 04
            Vector3 posicionPlayer = new Vector3(20.09f,-11.2f,0);
            this.transform.position = posicionPlayer;
        }

        if(obj.gameObject.tag == "Portal_16") { //Portal 14 a Portal 04
            Vector3 posicionPlayer = new Vector3(-42.725f,-6.7f,0);
            this.transform.position = posicionPlayer;
        }
    }
}
