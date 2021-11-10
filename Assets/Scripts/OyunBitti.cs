using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public Text puanText;
    public AudioClip oyunBittiSes;
    void Start()
    {

        puanText.text = "Puanýnýz : " + GameObject.Find("muzik&puan").GetComponent<puan>().puanAl();
        GetComponent<AudioSource>().PlayOneShot(oyunBittiSes);
    }
    public void AnaSahneyeGec()
    {
        SceneManager.LoadScene(0);
    }
    
}
