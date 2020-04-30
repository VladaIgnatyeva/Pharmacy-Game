using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CounterSpawner : MonoBehaviour
{
    public Transform[] spawnLacations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    public GameObject[] tax;

    void Start()
    {
        tax = GameObject.FindGameObjectsWithTag("Counter");
        if (tax.Length == 0) spawn();
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "main")
        {
            spawn1();
        }
    }

    void spawn()
    {
        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLacations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void spawn1()
    {
        whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLacations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
}
