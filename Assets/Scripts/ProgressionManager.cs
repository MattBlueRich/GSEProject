using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionManager : MonoBehaviour
{
    public PlayerMovement playerMovement;
    // public EntityPhysics entityPhysics
    public float moveSpeedIncrementSize;
    public float entityFallIncrementSize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.moveSpeed += Time.deltaTime * moveSpeedIncrementSize;
    }
}
