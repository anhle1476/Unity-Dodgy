using Assets.Scripts.Constants;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis(Axis.HORIZONTAL);
        float deltaZ = Input.GetAxis(Axis.VERTICAL);
        transform.Translate(new Vector3(deltaX, 0, deltaZ) * Time.deltaTime * moveSpeed);
    }
}
