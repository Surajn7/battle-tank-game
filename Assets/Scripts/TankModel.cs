using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    public TankController tankController;

    public TankType tankType;
    public int  health;
    public float speed;
    /*public TankModel(TankType _tankType,int _speed,int _health)
    {
        tankType = _tankType;
        speed = _speed;
        health = _health;
    }*/

    public TankModel(TankScriptableObject tankscritableObject)
    {
        tankType = tankscritableObject.tankType;
        speed = tankscritableObject.Speed;
        health = tankscritableObject.health;
    }
    public void SettankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
