using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    public GameObject blueCha, redCha, greenCha, yellowCha, Spawn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnNewCharacter", 0);
    }

    void SpawnNewCharacter()
    {
        if (Random.Range(1, 5) == 1)
            Spawn = Instantiate(blueCha, transform.position, Quaternion.identity) as GameObject;
        else if (Random.Range(1, 5) == 2)
            Spawn = Instantiate(redCha, transform.position, Quaternion.identity) as GameObject;
        else if (Random.Range(1, 5) == 3)
            Spawn = Instantiate(yellowCha, transform.position, Quaternion.identity) as GameObject;
        else
            Spawn = Instantiate(greenCha, transform.position, Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
