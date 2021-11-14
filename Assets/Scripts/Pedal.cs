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
        //transform.position = farepos; // Mouse nereye hareket ettirirsem pedal objem o yöne doðru hareket edecektir.
        //transform.position = new Vector3(Mathf.Clamp(farepos.x, -3f, 3f), transform.position.y, transform.position.z); //Sadece x yönünde mouse ile hareket etmeyi saðlar.
        transform.position = new Vector3(top.transform.position.x, transform.position.y, transform.position.z);
        //Bu kod ile pedal topu kendiliðinden takip edeceði için hiçbir þekilde ölmez.
    }
}
