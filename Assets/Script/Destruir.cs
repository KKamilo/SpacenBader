using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject exploxion;
    public GameObject playExploid;
    GameObject efecto1;
    GameObject efecto2;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            efecto1= (GameObject) Instantiate(exploxion, other.transform.position, other.transform.rotation);
            efecto2= (GameObject) Instantiate(playExploid, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Destroy(efecto1,3f);
            Destroy(efecto2,3f);
            Enemy.juego=false;
        }
        if (other.gameObject.tag == "bala")
        {
            efecto1= (GameObject) Instantiate(exploxion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Destroy(efecto1,3f);
            Enemy.boss= Enemy.boss-1;
        }
        
    }
}
