using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    public GameObject moveTo;
    private SpriteRenderer sprite;
    public GameObject projectile;
    private GameObject travellingProj;
    

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        InvokeRepeating("ChangeXPosition", 2.0f, 0.5f);
        InvokeRepeating("ShootProjectile", 1.0f, 2.0f);
        
        
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveTo.transform.position, speed * Time.deltaTime);
        var dir = moveTo.transform.position - transform.position;
        dir = dir.normalized;
        travellingProj.GetComponent<Rigidbody2D>().AddForce(dir * 10);

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

    void ShootProjectile()
    {
        travellingProj = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        
    }
}
