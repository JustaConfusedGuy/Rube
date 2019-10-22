using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partcleStart : MonoBehaviour
{
    [SerializeField]
    GameObject particle;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "vägg")
        {
            Instantiate(particle, new Vector3(40, 9 , 15), Quaternion.identity);
        }
    }
}
