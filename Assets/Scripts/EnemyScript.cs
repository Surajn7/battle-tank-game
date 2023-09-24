using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int Direction;
    public int health;
    public ParticleSystem Explosion;
    // Update is called once per frame
    void Update()
    {
        /**Vector3 move = transform.position;
        move.z = move.z + Direction * 1 * Time.deltaTime;
        transform.position = move;*/
    }

    public void takeDamage(int  damage)
    {
      health = health - damage;
        if (health <= 0)
        {
            Explosion.Play();
            Destroy(gameObject);
        }
    }
}
