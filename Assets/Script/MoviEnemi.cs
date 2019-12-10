using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviEnemi : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool juego = true;
    public int direccion;
    void Start()
    {
            Destroy(this.gameObject,10f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, Time.deltaTime *10, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag== "bala")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
