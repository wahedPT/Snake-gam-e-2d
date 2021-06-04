using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySnake : MonoBehaviour
{
    public AudioSource DieSound;

    void Start()
    {
        DieSound = GetComponent<AudioSource>(); 
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Snake")
        {

            DieSound.Play();
            print("Destroyed");
            Destroy(other.gameObject);
        }
    }


}
