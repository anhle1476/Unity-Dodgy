using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (!CompareTag("Hit") && collision.collider.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            tag = "Hit";
        }

    }
}
