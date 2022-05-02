using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float fallingCooldown = 3f;
    private bool isFalled = false;
    // Update is called once per frame
    MeshRenderer meshRenderer;
    Rigidbody rigitBody;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigitBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigitBody.useGravity = false;
    }


    private void Update()
    {
        if (isFalled == false && Time.time >= fallingCooldown)
        {
            Debug.Log(Time.time);
            meshRenderer.enabled = true;
            rigitBody.useGravity = true;
            isFalled = true;
        }
    }
}
