using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float Speed = 3f;

    public float lifeBoss = 150f;
    public GameObject WinninPanel;

    public GameObject shooter1;
    public GameObject shooter2;
    public GameObject shooter3;
    public GameObject shooter4;


    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * Speed);

        if (lifeBoss <= 0)
        {
            Destroy(this.gameObject);
            WinninPanel.SetActive(true);

        }



    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Bullet"))
        {
            lifeBoss = lifeBoss - collision.transform.GetComponent<Bullet>().damage;
        }
        if (collision.transform.CompareTag("tope Boss"))
        {
            Speed = 0;
            shooter1.SetActive(true);
            shooter2.SetActive(true);
            shooter3.SetActive(true);
            shooter4.SetActive(true);


        }

    }
    




}
