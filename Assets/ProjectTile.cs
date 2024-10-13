using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectTile : MonoBehaviour
{

    void Update()
    {
        transform.Translate(Vector3.forward * 50 * Time.deltaTime);
        Destroy(gameObject, 2f);
    }
}
