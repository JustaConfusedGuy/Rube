using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFlyttning : MonoBehaviour
{
    [SerializeField]
    GameObject kamra;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Raket")
        {
            kamra.transform.position = new Vector3(6, 19, -5);
        }
    }
}
