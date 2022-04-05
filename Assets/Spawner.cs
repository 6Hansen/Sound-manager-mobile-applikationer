using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject dogToSpawn;
    public GameObject cowToSpawn;
    public GameObject catToSpawn;


    public void SpawnDog()
    {
        Instantiate(dogToSpawn, transform.position, transform.rotation);
    }

    public void SpawnCow()
    {
        Instantiate(cowToSpawn, transform.position, transform.rotation);
    }

    public void SpawnCat()
    {
        Instantiate(catToSpawn, transform.position, transform.rotation);
    }
}
