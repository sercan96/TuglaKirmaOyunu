using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{

    
    void Update()
    {
        Vector3 farepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        //transform.position = farepos; // Mouse ile nereye g�t�r�rsem oraya obje gidecektir.
        transform.position = new Vector3(farepos.x, transform.position.y, transform.position.z); //Sadece x y�n�nde mouse ile hareket etmeyi sa�lar.

    }
}
