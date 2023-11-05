using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuSound : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
    public void PrevScene()
    {
        SceneManager.LoadScene(0);
    }
}
