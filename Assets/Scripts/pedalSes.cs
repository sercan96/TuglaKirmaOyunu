using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedalSes : MonoBehaviour
{
    public AudioClip pedalSesi;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().PlayOneShot(pedalSesi);
    }
}
