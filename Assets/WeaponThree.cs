using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponThree : WeaponScript
{
    protected override void RotateWeaponTowardsMouse()
    {
        base.RotateWeaponTowardsMouse();
    }

    protected override void Shoot()
    {
        isShooting = true;
        Instantiate(projectTile, bulletSP.position, transform.rotation);
        Invoke("ResetShot", 0.1f);
    }
}
