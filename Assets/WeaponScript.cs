using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] private Transform weapon;
    [SerializeField] private LayerMask shootLayer;
    public GameObject projectTile;

    public bool isShooting = false;
    public Transform bulletSP;

    void Update()
    {
        RotateWeaponTowardsMouse();
        bulletSP = GameObject.Find("BulletSpawnPoint").transform;

        if (Input.GetButton("Fire1") && !isShooting)
        {
            Shoot();
        }
    }

    protected virtual void RotateWeaponTowardsMouse()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        Ray ray =Camera.main.ScreenPointToRay(mouseScreenPosition);

        if (Physics.Raycast(ray, out RaycastHit hit,1000f, shootLayer))
        {
            Vector3 worldPosition = hit.point;
            Vector3 direction = (worldPosition - weapon.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(direction);

            weapon.rotation = lookRotation;
        }
    }

    protected virtual void Shoot()
    {
        isShooting = true;
        //reset shot
        Invoke("ResetShot", 10f);

    }

    void ResetShot()
    {
        isShooting = false;
    }
}
