using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Gun
{
    protected override void Update()
    {
        base.Update();
        //Shotgun and Pistol have semi-auto fire rate
        if (Input.GetMouseButton(0) && (Time.time - lastFireTime) > fireRate)
        {
            lastFireTime = Time.time;
            Fire();
        }
    }
}
