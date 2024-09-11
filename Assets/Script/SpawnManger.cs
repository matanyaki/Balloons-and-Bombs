using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstaclePreFap;
    private Vector3 spawnPos = new Vector3(20, 0, 0);
    private float startDely = 2;
    private float overTimeDely = 2;
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDely, overTimeDely);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePreFap, spawnPos, obstaclePreFap.transform.rotation);
        }
    }
}
