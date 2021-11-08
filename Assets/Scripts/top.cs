using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{
    private GameObject pedal;
    private bool oyunBasladi = false;  // Oyun baþlangýçta baþlamamýþ olacak.
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
    }

    
    void Update()
    {
        if(!oyunBasladi)  // if(!oyunBasladi)  ==) oyunBasladi=false ise bu iþlemi yapacaktýr.
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z); //pedalýn sadece x pozisyonunu al
        }
        
        if(Input.GetMouseButtonDown(0))
        {
            oyunBasladi = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);    
        }
    }
}
