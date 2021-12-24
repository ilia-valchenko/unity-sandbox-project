using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private const float YDeepValue = -50;
    private const float XInitialValue = (float)-13.893;
    private const float YInitialValue = (float)1.629;
    private const float ZInitialValue = (float)-16.072;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < YDeepValue)
        {
            transform.position = new Vector3(XInitialValue, YInitialValue, ZInitialValue);
        }
    }
}
