using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCounter : MonoBehaviour
{
    // These Static Variables are accessed in "checkpoint" Script
    public Transform[] checkPointArray;
    public static Transform[] checkpointA;
    public static int currentCheckpoint = 0;
    public static int currentLap = 0;
    public Vector2 startPos;
    public int Lap;

    void Start()
    {
        startPos = transform.position;
        currentCheckpoint = 0;
        currentLap = 0;

    }

    void Update()
    {
        Lap = currentLap;
        checkpointA = checkPointArray;
    }




} 
 
