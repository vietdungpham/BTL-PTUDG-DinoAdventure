using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBackgroundMusic : MonoBehaviour
{
    public AudioClip b1, b2, b3, b4, b5, b6, b7, b8, b9;
    private AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        int t = Random.RandomRange(1, 10);
        switch (t)
        {
            case 1:
                audioSrc.clip = b1;
                break;
            case 2:
                audioSrc.clip = b2;
                break;
            case 3:
                audioSrc.clip = b3;
                break;
            case 4:
                audioSrc.clip = b4;
                break;
            case 5:
                audioSrc.clip = b5;
                break;
            case 6:
                audioSrc.clip = b6;
                break;
            case 7:
                audioSrc.clip = b7;
                break;
            case 8:
                audioSrc.clip = b8;
                break;
            case 9:
                audioSrc.clip = b9;
                break;
            default:
                audioSrc.clip = b1;
                break;
        }
        audioSrc.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
