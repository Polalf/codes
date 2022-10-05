using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
   
    [SerializeField] private Transform shootctrl;
    public float bulletForce = 20f;

    [SerializeField] private KeyCode shootCoode;
    public float coldDown = 5f;
    private float timershoot = 0f;
    private bool canShoot = true;

    void Start()
    {

    }


    void Update()
    { 
        
        // disparo
        if (timershoot >= coldDown)
        {

            canShoot = true;
        }
        else
        {
            timershoot += Time.deltaTime;
        }

        if (Input.GetKey(shootCoode) && canShoot)
        {
            Shoot();
            canShoot = false;
            timershoot = 0;
        }
    }
    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootctrl.position, shootctrl.rotation);
        //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(shootctrl.up * bulletForce, ForceMode2D.Impulse);
    }
}
