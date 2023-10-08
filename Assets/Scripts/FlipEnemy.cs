using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
      /*if (collision.gameObject.GetComponent<EnemyScript>() != null)
        {
            Debug.Log("Enemy COllision ");
            EnemyScript Enemy = collision.gameObject.GetComponent<EnemyScript>();
            Quaternion Enemy_rotation = Enemy.transform.rotation;
            Enemy_rotation.y = 180 + Enemy_rotation.y;
            Enemy.transform.localRotation = Enemy_rotation;
            Enemy.Direction = -Enemy.Direction;
        }*/
    }
}
