using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour
{
    public float speed= 2f;
   

      

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.up* Time.deltaTime* speed);
    
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("tope cam"))
        { 
            speed = 0;
        }
            

    }
}
