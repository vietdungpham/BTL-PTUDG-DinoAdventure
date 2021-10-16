using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCactus : MonoBehaviour
{
    public GameObject Cactus, Cactus1, Cactus2, Spawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewCactus", 3, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnNewCactus()
    {
        if (Random.Range(1, 4) == 1)
            Spawn = Instantiate(Cactus, transform.position, Quaternion.identity) as GameObject;
        else if (Random.Range(1, 4) == 2)
            Spawn = Instantiate(Cactus1, transform.position, Quaternion.identity) as GameObject;
        else
            Spawn = Instantiate(Cactus2, transform.position, Quaternion.identity) as GameObject;
    }
}
