using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public static AudioClip jump, getItem;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        jump = Resources.Load<AudioClip>("jump");
        getItem = Resources.Load<AudioClip>("getItem");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(jump);
                break;
            case "getItem":
                audioSrc.PlayOneShot(getItem,0.07f);
                break;
        }
    }
}
