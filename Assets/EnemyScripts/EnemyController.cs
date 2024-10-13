using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Image healthImage;
    private int enemyHealth = 100;
    public int EnemyHealth
    {
        get { return enemyHealth; }
        set
        {
            if(value < 0)
            {
                Debug.Log("Can't implement negative value");
            }
            else
            {
                enemyHealth = value;
                if(enemyHealth <= 0)
                {
                    Die();
                }
            }
        }
    }



    void Update()
    {
        healthImage.fillAmount = (float)enemyHealth / 100;
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ProjectTile"))
        {
            EnemyHealth -= 10;
        }
    }
}
