using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float speedMoven = 25f;
    public Vector3 derecha = new Vector3();
    public Vector3 izquierda = new Vector3();
    void Start()
    {
        transform.position = new Vector3(0, -35, -3);
        derecha.x = Time.deltaTime * speedMoven;
        izquierda.x = Time.deltaTime * speedMoven;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x < 17 && !Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(derecha.x,0,0);
            transform.rotation = Quaternion.Euler(new Vector3(-90, -35, -5));
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.x > -17)
        {
            transform.position -= new Vector3(izquierda.x,0,0);
            transform.rotation = Quaternion.Euler(new Vector3(-90, 35, 5));
        }
        else
            transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 0));

        if (Input.GetKey(KeyCode.W) && transform.position.y < -3.17)
        {
            transform.position += new Vector3(0f, Time.deltaTime * speedMoven, 0);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > -35)
        {
            transform.position -= new Vector3(0f, Time.deltaTime *speedMoven , 0);
        }

    }
}
