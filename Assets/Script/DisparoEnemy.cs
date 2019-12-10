using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemy : MonoBehaviour
{
    public GameObject bala;
    GameObject insBala;
    float fireRate = 2f;
    float nexFire;
    float speed = 1000;
    void Start()
    {
        gameObject.transform.tag = "BalaEnemi";  
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nexFire)
        {
            insBala = Instantiate(bala, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            nexFire = Time.time + fireRate;
            insBala.transform.Rotate(Vector3.down * 0);
            Rigidbody ribiBala = insBala.GetComponent<Rigidbody>();
            ribiBala.AddForce(Vector3.down * speed);
            Destroy(insBala, 3f);
        }
    }
}
