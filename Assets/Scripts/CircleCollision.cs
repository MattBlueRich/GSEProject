using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fortune"))
        {
            scoreManager.FortuneScore();
            Debug.Log("FortuneTriggerFuckery");
        }

        if (collision.gameObject.CompareTag("Illusion"))
        {
            //Endgame
            Debug.Log("IllusionTriggerFuckery");
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
