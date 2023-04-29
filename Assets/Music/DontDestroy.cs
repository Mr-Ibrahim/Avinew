using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    AudioSource music;
    private void Start()
    {
       music = GetComponent<AudioSource>();
    }
    public void mute()
    {
        if (music.mute)
        {
            music.mute = false;
        }
        else
        {
            music.mute = true;
        }
    }
}
