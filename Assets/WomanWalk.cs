using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanWalk : MonoBehaviour
{
    private float zPositionChange = (float)-0.01;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -37)
        {
            transform.rotation = new Quaternion(transform.rotation.x, 0, transform.rotation.z, transform.rotation.w);
            zPositionChange = zPositionChange = (float)0.01;
        }

        if (transform.position.z > -15)
        {
            transform.rotation = new Quaternion(transform.rotation.x, 180, transform.rotation.z, transform.rotation.w);
            zPositionChange = zPositionChange = (float)-0.01;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + zPositionChange);
    }
}
