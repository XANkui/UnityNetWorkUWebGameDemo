using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerSpawn : NetworkBehaviour
{

    public GameObject My_plane;
    public Transform[] NetworkStartPosition;
    int spawnCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnStartClient()
    {

        Debug.Log("PlayerSpawn / OnStartClient");
        spawnCount = NetworkStartPosition.Length;
        for (int i =0; i < spawnCount; i++)
        {
            if (NetworkStartPosition[i].childCount == 0) {
                GameObject player = Instantiate(My_plane, NetworkStartPosition[i]) as GameObject;
                //NetworkServer.Spawn(player);
                break;
                
            }
        }            
    }

}
