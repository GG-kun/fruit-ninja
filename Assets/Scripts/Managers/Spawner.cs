using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Object")]
    [SerializeField]
    private Playable spawnable;

    // Time past since the last spawn
    private float timeSinceLast = 0;
    // Time that needs to pass for next spawn
    private float timeUntilNext = 0;
    [Header("Time")]
    [Tooltip("Minimum time that has to past for next spawn")]
    [SerializeField]
    // Minimum time that has to past for next spawn
    private float minTime = 0;
    [Tooltip("Maximum time that has to past for next spawn")]
    [SerializeField]
    // Maximum time that has to past for next spawn
    private float maxTime = 0;

    void Start() {
        timeUntilNext = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLast += Time.deltaTime;
        if(timeSinceLast >= timeUntilNext) {
            spawnable.Spawn();
            timeSinceLast = 0;
            timeUntilNext = Random.Range(minTime, maxTime);
        }   
    }    
}
