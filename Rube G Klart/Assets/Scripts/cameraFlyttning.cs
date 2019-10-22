using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFlyttning : MonoBehaviour
{

    [SerializeField]
    GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Raket")
        {
            camera.transform.position = new Vector3(6, 19, -5);
        }
    }

}
