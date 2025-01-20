using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeScript : MonoBehaviour
{

    public GameObject explosion;
    public float time = 5;
    public float damageRadius = 5;
    public float damage;

    private void GiveDamage()
    {
        //Берет все коллайдеры внутри сферы
        Collider[] colliders = Physics.OverlapSphere(transform.position, damageRadius);
        for(int i = 0; i < colliders.Length; i++)
        {
            //Проверить на Валеру

            //Проверить на игрока
            if (colliders[i].tag == "Player")
            {
                Health health = colliders[i].GetComponent<Health>();
                health.TakeDamage(damage);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, damageRadius);
    }

    private void Expload()
    {
        Instantiate(explosion, transform.position,Quaternion.identity);
        Destroy(gameObject);
        GiveDamage();
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Expload", time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
