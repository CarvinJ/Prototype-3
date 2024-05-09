using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] obstaclePrefeb;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()  
    {
        // Set random spawn location and random object index
         Vector3 spawnLocation = new Vector3(38, 5, 0);
        int index = Random.Range(0, obstaclePrefeb.Length);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefeb[index], spawnPos, obstaclePrefeb[index].transform.rotation);
        }
    }
    
}
