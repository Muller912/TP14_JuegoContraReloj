using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarEnEje : MonoBehaviour
{
    public float velocidad = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }
}
