using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall1 : MonoBehaviour
{
    bool isFalling = false;
    void Update()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        Debug.DrawRay(transform.position, -transform.up, Color.red);
        if(Physics.Raycast(ray))
            isFalling = true;
        if(isFalling)
            transform.position = new Vector3(transform.position.x, transform.position.y-1, transform.position.z);

    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Collision detected");
        isFalling = false;
    }
}
