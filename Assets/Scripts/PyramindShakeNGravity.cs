using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramindShakeNGravity : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float y;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(rb);
    }

    // Update is called once per frame
    void Update()
    {
        y += Time.deltaTime;
        rb.AddForce(0f,y, 1f);
    }
}
