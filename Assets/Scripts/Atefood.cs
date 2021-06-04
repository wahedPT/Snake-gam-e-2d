using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atefood : MonoBehaviour
{
    GameObject food;
    int FoodScore = 1;

    public AudioSource EatSound;

    void Start()
    {
        EatSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        
        //score and destroy
        if (col.gameObject.CompareTag("Food"))

        {
            print(col.gameObject.tag);
            EatSound.Play();
            Scorer scrobj = FindObjectOfType<Scorer>();
            scrobj.ScoreCal(FoodScore);
            food = col.gameObject;
            col.gameObject.SetActive(false);
            StartCoroutine(WaitForSpawn());

        }

       
    }

   

    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(0.5f);
        food.SetActive(true);
    }
}
