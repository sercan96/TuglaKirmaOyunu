using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puan : MonoBehaviour
{
    private int Puan;
    private Text puanArttirText;

    private void Start()
    {
        puanArttirText = GetComponent<Text>();
    }
    public void puanArttir()
    {
        Puan++;
        puanArttirText.text = "Puan : " + Puan;
    }
    public int puanAl()   //Toplam puaný hesaplar
    {
        return Puan;
    }

}
