using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed, defaultRadius, maxRadius;

    public float radius;
    float angle;

    private bool keyPressed;

    void Start()
    {
        radius = defaultRadius;
    }

    void Update()
    {
        angle += (moveSpeed / (radius * Mathf.PI * 2f)) * Time.deltaTime;
        transform.position = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * radius;

        if (Input.GetKey(KeyCode.Space))
        {
            radius = Mathf.Lerp(radius, maxRadius, 1 * Time.deltaTime);
            keyPressed = true;
        }
      
        if(Input.GetKeyUp(KeyCode.Space))
        {
            keyPressed = false;
            Debug.Log(keyPressed);
        }

        if(keyPressed == false)
        {
            if(radius != defaultRadius)
            {
                radius = Mathf.Lerp(radius, defaultRadius, 1 * Time.deltaTime);

            }

        }

    }

}

