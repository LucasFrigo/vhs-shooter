using UnityEngine;

public class GunMechanics : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;

    Animator anim;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
           

            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(fpsCam.transform.position, forward, Color.green);
        }
    }


    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            OnEnemyHit enemy = hit.transform.GetComponent<OnEnemyHit>();
            if (enemy != null) {
                enemy.TakeDamage(damage);
            }
        }
    }

   

}
