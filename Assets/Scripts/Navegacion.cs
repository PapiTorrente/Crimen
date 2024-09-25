using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public void Jugar() {
        SceneManager.LoadScene("Juego");
    }

    //Pantalla de Muerte
    public void Reaparecer() {
        SceneManager.LoadScene("Juego");
    }
    public void Regresar() {
        SceneManager.LoadScene("MenuInicio");
    }
}
