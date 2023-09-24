using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    public TankView tankView;
    public TankScriptableObject[] tankConfigurations;
    public int speed, health;
    public void Start()
    {
        int Number = Random.Range(1, 3);
        create(Number);
    }

    private TankController create(int randomNumber)
    {
        TankScriptableObject tankScriptableObject =  tankConfigurations[randomNumber];
        TankModel tankModel = new TankModel(tankScriptableObject);
        //TankModel tankModel = new TankModel(TankType.None,speed,health);
        TankController tankController = new TankController(tankModel,tankView);
        return tankController;
    }
}
