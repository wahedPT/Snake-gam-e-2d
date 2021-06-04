using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snakerotate : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 180);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 90);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, -90);
        }

    }
}
