using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    GameObject insBala;
    float fireRate=0.3f;
    float nexFire;
    float speed= 1000;
    
    void Start()
    {
        gameObject.transform.tag = "bala";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time> nexFire)
        {
             insBala= Instantiate(bala, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            nexFire = Time.time + fireRate;
            insBala.transform.Rotate(Vector3.up *0);
            Rigidbody ribiBala = insBala.GetComponent<Rigidbody>();
            ribiBala.AddForce(Vector3.up * speed);
            Destroy(insBala, 3f);
        }
    }
}
