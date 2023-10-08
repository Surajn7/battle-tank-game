using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform[] points;
    public int speed;
    int current;
    public int health;
    public ParticleSystem Explosion;
    // Update is called once per frame
    void Update()
    {
        /**Vector3 move = transform.position;
        move.z = move.z + Direction * 1 * Time.deltaTime;
        transform.position = move;*/
        if(transform.position!=points[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
        }
        else
        {
            current = (current + 1)%points.Length;
        }
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
