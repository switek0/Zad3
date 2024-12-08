using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 

    public float speed = 5;

 

    void Start()
    {
      
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if(transform.position.x > -7f)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 7f)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }
    }    
        
}