using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snakemove : MonoBehaviour
{
    

  public float xValue = 0.1f;
  public float yValue = 0.1f;
    Vector2 dir = Vector2.right;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start the game");
    }

    // Update is called once per frame
    void Update()
    {
        //up
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,yValue, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -yValue, 0);
          
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-xValue, 0, 0);
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(xValue, 0, 0);
           
        }
    }

    


}
