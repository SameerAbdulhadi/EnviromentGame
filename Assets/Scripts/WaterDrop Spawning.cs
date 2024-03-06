using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropSpawning : MonoBehaviour
{
    public GameObject waterDrop;
    public float SpawnRate;
    public float SpawnStartTime;
    public float SpawnEndTime;
    public GameObject RespawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn",SpawnStartTime,SpawnRate);
        Invoke("CancelInvoke", SpawnEndTime);
    }
    public void spawn()
    {
        
        GameObject drop =  Instantiate(waterDrop);
        waterDrop.transform.position = RespawnPoint.transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
