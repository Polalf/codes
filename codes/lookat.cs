using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{

    public GameObject target;
    public float offset;


    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    void Update()
    {
        // transform.LookAt(target.transform);
        // Quaternion rotation = Quaternion.LookRotation
        // (target.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        //float angle = rotation.eulerAngles.z;
        // transform.rotation = Quaternion.Euler(0,0, angle + offset);
        float angle = Mathf.Atan2(target.transform.position.y - transform.position.y, target.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));

    }
}
