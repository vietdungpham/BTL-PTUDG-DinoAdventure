using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private float length, startPos;
    public GameObject camera;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = ((camera.transform.position.x+14) * (1 - parallaxEffect));
        float dist = ((camera.transform.position.x+14) * parallaxEffect);
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
        if (temp > startPos + length)
            startPos += length;
        else if (temp < startPos - length)
            startPos -= length;
    }
}
