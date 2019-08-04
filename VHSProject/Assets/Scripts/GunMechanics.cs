using UnityEngine;

public class GunMechanics : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            OnEnemyHit enemy = hit.transform.GetComponent<OnEnemyHit>();
            if(enemy != null){
                enemy.TakeDamage(damage);
            }
        }


    }

}
