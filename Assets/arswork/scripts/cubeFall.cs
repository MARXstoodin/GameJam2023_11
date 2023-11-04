using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using static UnityEngine.GraphicsBuffer;

public class cubeFall : MonoBehaviour
{
    public Transform Level;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(NotSoSmoothRotate(new Vector3(1, 0, 0)));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            NotSoSmoothRotate(new Vector3(0, 1, 0));
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            NotSoSmoothRotate(new Vector3(-1, 0, 0));
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            NotSoSmoothRotate(new Vector3(0, -1, 0));
        }
    }
    /*
    IEnumerator SmoothRotate(float angleX, float angleY, float angleZ, float duration)
    {
        float startX = Level.position.x, startY = Level.position.y, startZ = Level.position.z;
        for (float counter = 0f; counter <= 1f; counter += Time.deltaTime / duration)
        {
            Level.rotation = Quaternion.Euler(startX + counter * angleX, startY + counter * angleY, startZ + counter * angleZ);
            yield return null;
        }
    }
    */
    IEnumerator NotSoSmoothRotate(Vector3 rotationVec)
    {
        int angle = 0;
        while (angle < 90)
        {
            print(angle);
            Level.RotateAround(Level.position, rotationVec, 10);
            angle += 10;
            yield return new WaitForSeconds(1f);
        }
    }
}
