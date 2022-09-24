using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    
    [Header("Speed")]
    [Tooltip("Gameplay scene speed")]
    [SerializeField]
    private float speed = 0.5f;
    
    void Begin() {
        Time.timeScale = speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        Begin();
    }

    public void Finish() {
        Time.timeScale = 1;
    }
}
