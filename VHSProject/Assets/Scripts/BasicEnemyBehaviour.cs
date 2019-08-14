using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    public GameObject moveTo;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        InvokeRepeating("ChangeXPosition", 2.0f, 4.0f);
    }

    void FixedUpdate()
    {
        //transform.position = Vector3.MoveTowards(transform.position, moveTo.transform.position, speed * Time.deltaTime);
        
       

    }

    void ChangeXPosition()
    {
        if (!sprite.flipX)
        {
            sprite.flipX = true;
            Debug.Log("Changed X pos to true");
        }
        else
        {
            sprite.flipX = false;
            Debug.Log("Changed X pos to false");
        }
    }
}
