using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLooker : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Camera mainCam;

    private void Start()
    {
        if (mainCam == null)
        {
            mainCam = Camera.main;
        }
    }
    void Update()
    {
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector3 lookAtDir = mousePos - target.position;
        target.up = lookAtDir;
    }
}
