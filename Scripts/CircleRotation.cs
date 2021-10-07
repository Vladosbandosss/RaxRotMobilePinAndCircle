using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed =50f;
    float anfleZ;
  
    void Update()
    {
        RotateCircle();
    }

    private void RotateCircle()
    {
        anfleZ = transform.rotation.eulerAngles.z;
        anfleZ += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, 0f, anfleZ);
    }
}
