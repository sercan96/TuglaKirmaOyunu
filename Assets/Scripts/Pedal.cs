using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    private GameObject top;

    private void Start()
    {
        top = GameObject.Find("top");
    }
    void Update()
    {
        Vector3 farepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        //transform.position = farepos; // Mouse nereye hareket ettirirsem pedal objem o y�ne do�ru hareket edecektir.
        //transform.position = new Vector3(Mathf.Clamp(farepos.x, -3f, 3f), transform.position.y, transform.position.z); //Sadece x y�n�nde mouse ile hareket etmeyi sa�lar.
        transform.position = new Vector3(top.transform.position.x, transform.position.y, transform.position.z);
        //Bu kod ile pedal topu kendili�inden takip edece�i i�in hi�bir �ekilde �lmez.
    }
}
