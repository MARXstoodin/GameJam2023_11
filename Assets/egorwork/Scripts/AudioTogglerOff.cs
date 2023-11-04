using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTogglerOff : MonoBehaviour
{
    [Header("Parametrs")]
    public bool isOff;

    private void Start()
    {
        isOff = true;
    }
    public void OnOffSounds()
    {
        if (!isOff)
        {
            AudioListener.volume=0f;
            isOff=true;
        }
        else if (isOff)
        {
            AudioListener.volume =1f;
            isOff=false;
        }
        
    }
}
