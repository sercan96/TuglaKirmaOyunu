using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class puan : MonoBehaviour
{
    private int Puan;
  
    private void Start()
    {
    
    }
    public void puanArttir()
    {
        Puan++;
       
    }
    public int puanAl()   //Toplam puaný hesaplar
    {
        return Puan;
    }
    public void AnaSahneyeGec()
    {
        SceneManager.LoadScene(0);
    }
    public void PuanSifirla()
    {
        Puan = 0;
    }
}
