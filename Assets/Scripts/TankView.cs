using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    [SerializeField]public Joystick joystick;
    public TankController tankController;
    private float movement;
    private float rotation;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (joystick.Vertical != 0)
            tankController.Move(movement, 20);
        if (joystick.Horizontal != 0)
            tankController.Rotate(rotation, 15);
    }

    private void Movement()
    {
        movement = joystick.Vertical * 1f;
        rotation = joystick.Horizontal * 1f;
    }
    public void SettankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
