using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private TankScriptableObject tankScriptableObject;
    private Rigidbody rb;
    public TankController(TankModel _tankModel,TankView _tankView)
    {
        tankModel = _tankModel;
        tankView  = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();
        tankModel.SettankController(this);
        tankView.SettankController(this);
    }

    public void Move(float movement)
    {
        rb.velocity = tankView.transform.forward * movement * tankModel.speed;
        //Debug.Log("Speed of tank " + tankModel.speed);
    } 

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public void Shoot()
    {
        RaycastHit ray;
        if (Physics.Raycast(tankView.gameObject.transform.position, tankView.transform.forward, out ray))
        {
            Debug.Log(ray.transform.name);
            EnemyScript enemy = ray.transform.GetComponent<EnemyScript>();
            if (enemy != null)
            { enemy.takeDamage(20); }
        }
    }
}
