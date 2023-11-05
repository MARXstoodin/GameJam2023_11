using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CudeFall2 : MonoBehaviour
{
    public GameObject UwOn;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "win")
        {
            UwOn.SetActive(true);
            StartCoroutine(NextLVL());
        }
        if (collision.gameObject.tag == "lose")
        {
            SceneManager.LoadScene("lvl02");
        }
    }
    IEnumerator NextLVL()
    {
        yield return new WaitForSeconds(1.25f);
        SceneManager.LoadScene("menu");
    }
}
