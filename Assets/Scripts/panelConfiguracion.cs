using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelConfiguracion : MonoBehaviour
{

    //Configuración de Video
    public Toggle toggleSilencio;
    public float valorReferencia;
    public Slider sliderVolumen;
    public float valorSliderVolumen;

    //Configuración de Video
    public Toggle toggleFullScreen;
    public Slider sliderBrillo;
    public float valorSliderBrillo;
    public Image imgBrillo;


    void Start() {
        //Volumen
        toggleSilencio.isOn = AudioListener.volume > 0;
        sliderVolumen.value = PlayerPrefs.GetFloat("volumen", 0.45f);
        AudioListener.volume = sliderVolumen.value;

        //Pantalla Completa
        if(Screen.fullScreen) {
            toggleFullScreen.isOn = true;
        } else {
            toggleFullScreen.isOn = false;
        }

        //Brillo
        sliderBrillo.value = PlayerPrefs.GetFloat("brillo", 0.45f);
        imgBrillo.color = new Color(imgBrillo.color.r, imgBrillo.color.g, imgBrillo.color.b, sliderBrillo.value);
    }

    public void ActivarAudio(bool audio) {
        if(toggleSilencio.isOn) {
            valorReferencia = AudioListener.volume;
            AudioListener.volume = 0f;
            sliderVolumen.value = 0f;
        } else {
            AudioListener.volume = valorReferencia;
            sliderVolumen.value = valorReferencia;
        }
    }

    public void ChangeSliderVolumen(float valor){
        valorSliderVolumen = valor;
        PlayerPrefs.SetFloat("volumen", valorSliderVolumen);
        AudioListener.volume = sliderVolumen.value;
    }

    public void ActivarPantallaCompleta(bool pantallaCompleta) {
        Screen.fullScreen = pantallaCompleta;
    }

    public void ChangeSliderBrillo(float valor) {
        
        valorSliderBrillo = valor;
        PlayerPrefs.SetFloat("brillo", valorSliderBrillo);
        imgBrillo.color = new Color(imgBrillo.color.r, imgBrillo.color.g, imgBrillo.color.b, sliderBrillo.value);
    }
}
