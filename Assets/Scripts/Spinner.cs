using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float spinningSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate arround the Y axis (center horizontal)
        transform.Rotate(0f, 100 * spinningSpeed * Time.deltaTime, 0f);
    }
}
