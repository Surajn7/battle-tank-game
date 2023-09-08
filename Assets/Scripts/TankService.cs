using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{
    public TankView tankView;

    public void Start()
    {
        create();
    }

    private TankController create()
    {
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel,tankView);
        return tankController;
    }
}
