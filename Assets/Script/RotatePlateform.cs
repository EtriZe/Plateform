using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlateform : MonoBehaviour
{
    private float speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveZ = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * moveZ * speed*  Time.deltaTime);
        float moveX = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.back * moveX * speed*  Time.deltaTime);
    }
 
}
