using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTwo : WeaponScript
{
    protected override void RotateWeaponTowardsMouse()
    {
        base.RotateWeaponTowardsMouse();
    }

    protected override void Shoot()
    {
        isShooting = true;

        //instantiate bullet
        Instantiate(projectTile, bulletSP.position, transform.rotation);
        Invoke("ResetShot", 0.5f);
    }
}
