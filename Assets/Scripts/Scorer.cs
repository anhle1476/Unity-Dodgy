using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumps = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Hit"))
        {
            Debug.Log($"Bumped {++bumps} times");
        }
    }
}
