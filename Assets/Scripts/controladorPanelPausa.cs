using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorPanelPausa : MonoBehaviour
{
    public bool estaPausado = false;
    public GameObject menuPausa;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            activarPausa();
        }
    }

    private void activarPausa() {
        if(!estaPausado){ //Si no está pausado, se pausa el juego y se activa la pantalla.
            Time.timeScale = 0f;
            menuPausa.SetActive(true);
            estaPausado = true;
        } else {
            Time.timeScale = 1f;
            menuPausa.SetActive(false);
            estaPausado = false;
        }
    }
}
