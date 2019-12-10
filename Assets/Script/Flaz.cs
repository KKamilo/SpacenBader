using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flaz : MonoBehaviour
{
    public GameObject flash1;
    public GameObject flash2;
    void Start()
    {
        flash1.SetActive(false);
        flash2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            flash1.SetActive(true);
            flash2.SetActive(true);
        }
        else
        {
            flash1.SetActive(false);
            flash2.SetActive(false);
        }
    }
}
