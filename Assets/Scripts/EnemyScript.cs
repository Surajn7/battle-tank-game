using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    public int health;
    public GameManager gameManager;
    //public ParticleSystem Explosion;
    public Transform[] points;
    int current,Score;
    // Update is called once per frame
    void Update()
    {
        if (transform.position != points[current].position)
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
        else
            current = (current + 1) % points.Length;

    }

    public void takeDamage()
    {
        if (health <= 0)
        {
            gameManager.CheckObjects();
            StartCoroutine(Death(2f));            
        }
        health -= 10;        
    }

    private IEnumerator Death(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}
