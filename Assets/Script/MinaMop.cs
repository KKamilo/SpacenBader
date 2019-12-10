using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinaMop : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 150;
    void Start()
    {
        Destroy(this.gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, Time.deltaTime * 10, 0);
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0),Space.World );
    }
    
}
