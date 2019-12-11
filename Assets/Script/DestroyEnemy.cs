using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") //Para una colicion en 2d se deve comparar con el gameObject
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
}
