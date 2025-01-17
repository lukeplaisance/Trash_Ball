﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class WindFanBehaviour : MonoBehaviour
{
    public ConstantForce cf;
    private Random random;


    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.GetComponent<ConstantForce>().enabled = true;

        cf.force = new Vector3(Random.Range(0, 11), 0, 0);
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    other.attachedRigidbody.GetComponent<ConstantForce>();
    //    cf.force = new Vector3(-20, -5, 0);
    //}
}
