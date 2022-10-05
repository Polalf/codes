using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float life = 20f;
    
    
    void Start()
    {
        
    }

      private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Bullet"))
        {

            life = life - collision.transform.GetComponent<Bullet>().damage; 
        }
        
    }
    void Update()
    {
        if(life<= 0)
        {
            Destroy(this.gameObject);
        }

    }
  
    
}
