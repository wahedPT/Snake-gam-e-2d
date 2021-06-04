using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foodspawn : MonoBehaviour
{
   
    void Start()
    {
       // InvokeRepeating("Foodspwn", spawnTime, spawnDelay);
        Foodspwn();
    }

    private void OnEnable()
    {
        Foodspwn();
    }

    public  void Foodspwn()
    {
        float x = Random.Range(-12.48f, 12.48f);
        float y = Random.Range(19.05f, -19.05f);
        Vector2 foodpos = new Vector2(x, y);
        transform.position = foodpos;
    }

    
   
  
}
