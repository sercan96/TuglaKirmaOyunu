using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvarSes : MonoBehaviour
{
    public AudioClip duvarSesi;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().PlayOneShot(duvarSesi);
    }
}
