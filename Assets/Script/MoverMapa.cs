using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverMapa : MonoBehaviour
{
    public float scrollMap;
    public float length;
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        scrollMap = -25f;
        length = 50;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollMap, length);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}
