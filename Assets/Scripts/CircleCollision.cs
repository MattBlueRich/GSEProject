using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleCollision : MonoBehaviour
{
    public ScoreManager scoreManager;

    private Object particleRef;

    private void Start()
    {
        particleRef = Resources.Load("FortuneParticle");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fortune"))
        {
            scoreManager.FortuneScore();

            GameObject explosion = (GameObject)Instantiate(particleRef);
            explosion.transform.position = transform.position;
            Destroy(explosion, 1f);

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Illusion"))
        {
            Destroy(gameObject);
        }
    }
}
