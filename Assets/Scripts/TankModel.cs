using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    public TankController tankController;

    public TankModel()
    {
        
    }

    public void SettankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
