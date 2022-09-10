using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
    public string _Cena;
    [SerializeField] private TMP_Text volumeTextoValor = null;
    [SerializeField] private Slider volumeSlider = null;


    public void IniciarJogo()
    {
        SceneManager.LoadScene(_Cena);
    }

    public void AjustarVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTextoValor.text = volume.ToString("0%");
    }
    public void VolumeSet()
    {
        PlayerPrefs.SetFloat("VolumeGeral", AudioListener.volume);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
