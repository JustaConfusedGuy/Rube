using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pushed_object : MonoBehaviour
{
   
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "fly")
        {
            rb.AddForce(250, 250, 0);
        }
        }




}

/*
 * 
 *rb.AddForce(0, Impulse, 0, ForceMode.Impulse);
 * 
*/
