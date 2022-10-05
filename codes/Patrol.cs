using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    
    
    void Update()
    {
       transform.Translate(Vector2.right * Time.deltaTime * speed);
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Tope"))
            speed *= -1;
    }
}
