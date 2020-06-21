using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawneer : MonoBehaviour
{
    public float xRange = 10.0f;
    public float zRange = 1000.0f;
    public GameObject[] animals;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 0f, zRange);
        int animalIndex = Random.Range(0, animals.Length);
        Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation);
    }
}
