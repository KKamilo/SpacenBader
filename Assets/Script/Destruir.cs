using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject exploxion;
    public GameObject playExploid;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag== "Player")
        {
            Instantiate(exploxion, other.transform.position, other.transform.rotation);
        }
        Instantiate(playExploid, transform.position, transform.rotation);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
