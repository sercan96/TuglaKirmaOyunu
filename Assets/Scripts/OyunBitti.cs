using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public Text puanText;
    void Start()
    {

        puanText.text = "Puanýnýz : " + GameObject.Find("muzik&puan").GetComponent<puan>().puanAl();
    }
    public void AnaSahneyeGec()
    {
        SceneManager.LoadScene(0);
    }
}
