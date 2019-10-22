using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera2 : MonoBehaviour
{
    [SerializeField]
    GameObject kamera;

    private void OnTriggerEnter(Collider other)
    {
        kamera.transform.position = new Vector3(30 , 9, -2);
    }
}
