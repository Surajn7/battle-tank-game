using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    [SerializeField]
    public Joystick joystick;
    public TankController tankController;
    private TankScriptableObject tankScriptableObject;
    private float movement;
    private float rotation;
    public Rigidbody rb;
    public GameObject Explosion;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint; 
    public float bulletspeed;
    public ParticleSystem muzzleFlash;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetButtonDown("Fire1"))
        {
           muzzleFlash.Play();
           Shoot(); 
        }
        //if (joystick.Vertical != 0)
        if(movement != 0)
            tankController.Move(movement);        
        //if (joystick.Horizontal != 0)
        if(rotation!=0)
            tankController.Rotate(rotation, 35);
    }

    private void Movement()
    {
        //movement = joystick.Vertical * 1f;
        movement = Input.GetAxis("Vertical");
        //rotation = joystick.Horizontal * 1f;
        rotation = Input.GetAxis("Horizontal");
    }
    public void SettankController(TankController _tankController)
    {
        tankController = _tankController;
    }
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    public void PlayParticleSystem()
    {
        Explosion.SetActive(true);
        if (Explosion.activeSelf == true)
            Debug.Log("Particle System is active ");
    }

    public void Shoot()
    {
        var bullet = Instantiate(bulletPrefab,bulletSpawnPoint.position,bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
    }
}
