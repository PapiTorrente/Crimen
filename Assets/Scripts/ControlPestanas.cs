using UnityEngine;
using UnityEngine.UI;

public class ControlPestanas : MonoBehaviour
{
    public GameObject[] Pestanas;
    public Image[] Botones;
    public Sprite BtnActivo, BtnInactivo;
    public Vector2 TamañoBtnActivo, TamañoBtnInactivo;

    public void CambiarPestana(int IdPestana) {
        foreach(GameObject pestana in Pestanas) {
            pestana.SetActive(false);
        }
        Pestanas[IdPestana].SetActive(true);

        foreach(Image imagen in Botones) {
            imagen.sprite = BtnInactivo;
            imagen.rectTransform.sizeDelta = TamañoBtnInactivo;
        }
        Botones[IdPestana].sprite = BtnActivo;
        Botones[IdPestana].rectTransform.sizeDelta = TamañoBtnActivo;
    }
}
