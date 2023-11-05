using System.Collections;
using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    public Transform Level, cube;
    bool rotateble = true;   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && rotateble)
        {
            StartCoroutine(NotSoSmoothRotate(new Vector3(1, 0, 0)));
        }
        else if (Input.GetKeyDown(KeyCode.S) && rotateble)
        {
            StartCoroutine(NotSoSmoothRotate(new Vector3(-1, 0, 0)));
        }
        else if (Input.GetKeyDown(KeyCode.A) && rotateble)
        {
            StartCoroutine(NotSoSmoothRotate(new Vector3(0, 1, 0)));
        }
        else if (Input.GetKeyDown(KeyCode.D) && rotateble)
        {
            StartCoroutine(NotSoSmoothRotate(new Vector3(0, -1, 0)));
        }
        else if (Input.GetKeyDown(KeyCode.Q) && rotateble)
        {
            StartCoroutine(NotSoSmoothRotate(new Vector3(0, 0, 1)));
        }
        else if (Input.GetKeyDown(KeyCode.E) && rotateble)
        {
            StartCoroutine(NotSoSmoothRotate(new Vector3(0, 0, -1)));
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
        rotateble = false;
        int angle = 0;
        while (angle < 90)
        {
            print(angle);
            Level.RotateAround(Level.position, rotationVec, 1);
            angle += 1;
            yield return new WaitForSeconds(0.001f);
        }
        rotateble = true;
    }
}
