using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
   public void butonBas()
    {
        tugla.toplamTuglaSayisi = 0;
        GameObject.Find("muzik&puan").GetComponent<puan>().PuanSifirla();
        SceneManager.LoadScene("bolum1");
    }
}
