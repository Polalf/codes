using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //movimiento
    [SerializeField] private Animator playerAnimator;
    public float rotate;
    public float speed;
    private Rigidbody2D Rb;

    //vida
    public float maxLife = 100f;
    public float life;
    public GameObject GameOver;
    public HealthBar healthBar;
    

    public GameObject Boss;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        life = maxLife;
        healthBar.SetMaxHealth(maxLife);
    }


    void Update()
    {
        // vida
        if (life <= 0)
        {
            Destroy(this.gameObject);
            // game over
            GameOver.SetActive(true);

        }
        if(life>maxLife)
        {
            life = maxLife;
        }

        //movimiento
        float moveY = Input.GetAxisRaw("Vertical");
        if (moveY == -1)
        {
            Rb.velocity = transform.up * -speed;
        }
        if (moveY == 1)
        {
            Rb.velocity = transform.up * speed;
        }
        float moveX = Input.GetAxisRaw("Horizontal");


        if (moveX == -1)
        {
            transform.Rotate(0, 0, rotate * Time.deltaTime);
            //playerAnimator.set
        }
        if (moveX == 1)
        {
            transform.Rotate(0, 0, -rotate * Time.deltaTime);
        }
        playerAnimator.SetFloat("speed", moveY);

        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("BE"))
        {

            life = life - collision.transform.GetComponent<Bullet>().damage;
            healthBar.SetHealth(life);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("BossBattle"))
        {
            Boss.SetActive(true);
        }
        if(collision.transform.CompareTag("Life"))
        {
            life = life + collision.transform.GetComponent<Life>().dropLife;
            healthBar.SetHealth(life);
        }
        if(collision.transform.CompareTag("Bordes"))
        {
            GameOver.SetActive(true);
        }
       
    }
    





}
