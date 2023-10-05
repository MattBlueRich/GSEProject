using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField]
    private ObjectSpawner objectSpawnerScript;
    
    void Start()
    {

    }

    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Illusion"))
        {
            objectSpawnerScript.illusionsInGame.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }

       else if (collision.gameObject.CompareTag("Fortune"))
        {
            objectSpawnerScript.fortunesInGame.Remove(collision.gameObject);
            Destroy(collision.gameObject);

        }
    }
}

