using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public string spawnPointTag = "sometag";
    public bool alwaysSpawn = true;

    public List<GameObject> prefabsToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
        foreach (GameObject spawnPoint in spawnPoints)
        {
            int randomPrefab = Random.Range(0, prefabsToSpawn.Count);
            if (alwaysSpawn)
            {
                GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
                pts.transform.position = spawnPoint.transform.position;
            }
            /*
            else
            {
                int spawnOrNot = Random.Range(0, 2);
                if (spawnOrNot == 0)
                {
                    GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
                    pts.transform.position = spawnPoint.transform.position;
                } 
            }
            */
        }
    }

}

/*
 public GameObject[] spawnLocations;

    public GameObject objectToSpawn;

    

    private Vector3 respawnLocation;

    void Awake()
    {
        spawnLocations = GameObject.FindGameObjectWithTag("spawns");
    }

    void Start()
    {
        objectToSpawn = (GameObject)Resources.Load("battery1", typeof(GameObject));
        respawnLocation = objectToSpawn.transform.position;
        SpawnBattery();
    }

    // Update is called once per frame
    private void SpawnBattery()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(objectToSpawn, spawnLocations[spawn].transform.position, Quaternion.identity);
    }

*/