using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource MyFx;
    public AudioClip HoverFx;
    public AudioClip ClickFx;

    public void HoverSound()
    {
        MyFx.PlayOneShot(HoverFx);
    }

    public void ClickSound()
    {
        MyFx.PlayOneShot(ClickFx);
    }
    public void QuitButton()
    {
        Debug.Log("Game is Exit");
        Application.Quit();
    }
}
