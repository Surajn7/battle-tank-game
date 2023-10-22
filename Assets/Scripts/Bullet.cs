using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life;
    //public EnemyScript enemy;
   
    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "EnemyTank")
        { 
            EnemyScript enemy = collision.gameObject.GetComponent<EnemyScript>();
            enemy.takeDamage();
            Destroy(this.gameObject);
        }
        Destroy(gameObject,life);
    }
}
