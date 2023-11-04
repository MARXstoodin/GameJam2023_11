using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayLogic : MonoBehaviour
{
    public void Scenes()
    {
        SceneManager.LoadScene("lvl01");

    }
    public GameObject pauseMenuUI;
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
    }
}
