using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityPhysics : MonoBehaviour
{ 
    [SerializeField]
    private float moveSpeed = 1f; // How fast the enemies' move to start with

    Rigidbody2D rb2D;

    private ObjectSpawner objectSpawnerScript;

    [SerializeField]
    private bool isIllusion;

    void Start()
    {
        objectSpawnerScript = GameObject.Find("SpawnManager").GetComponent<ObjectSpawner>(); // Object needs to be called SpawnManager in scene to get the script
         rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y <= -7)
        {
            if(isIllusion == true)
            {
                objectSpawnerScript.illusionsInGame.Remove(gameObject); // Remove illusion from the list of illusions in game and destroys it
                Destroy(gameObject);
            }
        }

        else if(isIllusion == false)
        {
            objectSpawnerScript.fortunesInGame.Remove(gameObject); // Remove fortune from the list of fortunes in game and destroys it
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb2D.velocity = new Vector2(0, -moveSpeed);
    }
}
