using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SoundKiller : MonoBehaviour
{
    public static bool sound = true;
    private void Start()
    {
        if (sound)
        {
            this.gameObject.GetComponent<AudioListener>();
            AudioListener.volume = 1;
            GameObject.Find("SoundOff").active = true;
            GameObject.Find("SoundOn").active = false;
        }
        else
        {
            this.gameObject.GetComponent<AudioListener>();
            AudioListener.volume = 0;
            GameObject.Find("SoundOn").active = true;
            GameObject.Find("SoundOff").active = false;

        }
    }
    public void SoundOff()
    {
        this.gameObject.GetComponent<AudioListener>();
        AudioListener.volume = 0;
        sound = false;
        //GameObject.Find("SoundOff").active = true;
        //GameObject.Find("SoundOn").active = false;
    }
    public void SoundOn()
    {
        this.gameObject.GetComponent<AudioListener>();
        AudioListener.volume = 1;
        sound = true;
        //GameObject.Find("SoundOn").active = true;
        //GameObject.Find("SoundOff").active = false;
    }


}
