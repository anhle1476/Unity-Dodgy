using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    [SerializeField]
    float fallingCooldown = 3f;
    private bool isFalled = false;
    // Update is called once per frame
    void Update()
    {
        if (isFalled == false && Time.time >= fallingCooldown)
        {
            Debug.Log(Time.time);
            GetComponent<Rigidbody>().useGravity = true;
            isFalled = true;
        }
    }
}
