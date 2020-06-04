using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    public float speed = 80.56f;

    //private Rigidbody planeRigidbody;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("flight added to: " + gameObject.name);

       // planeRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        //turnInput = Input.GetAxis("Horizontal");

        transform.position += transform.forward * Time.deltaTime * speed;

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        float heightGround = Terrain.activeTerrain.SampleHeight(transform.position);

        if (heightGround > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, heightGround, transform.position.z);
        }

    }

}
