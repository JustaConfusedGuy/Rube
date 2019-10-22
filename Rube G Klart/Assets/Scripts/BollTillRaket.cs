using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BollTillRaket : MonoBehaviour
{

    [SerializeField]
    GameObject raketFlöde;

    Transform raketTransform;

    [SerializeField]
    GameObject raket;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Definera rb
        raketTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Boll")
        {
            rb.velocity = new Vector3(0,10,0);
        }
    }

}
