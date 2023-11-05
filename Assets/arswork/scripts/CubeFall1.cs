using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall1 : MonoBehaviour
{
    bool isFalling = false;
    void Update()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        if(Physics.Raycast(ray,100))
            isFalling = true;
        Debug.DrawRay(transform.position, -transform.up, Color.red, 2f);
        if (isFalling)
            transform.position = new Vector3(transform.position.x, transform.position.y-0.01f, transform.position.z);

    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Collision detected");
        isFalling = false;
    }
}
