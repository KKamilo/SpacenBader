using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

    public DatoEnemi datoEnemi;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject mina;
    public static bool juego = true;
    public float enemy1X;
    public float enemy2X;
    float minax;
   
    void Start()
    {
        StartCoroutine(Spaun());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public struct DatoEnemi
    {
        public int health;
        public int attack;
    }
    IEnumerator Spaun()
    {
        while(juego)
        {
            int numEnemi = Random.Range(1, 4);
            for (int i = 0; i < numEnemi; i++)
            {
                int enemy = Random.Range(0, 3);
                switch(enemy)
                {
                    case 0:
                        enemy1X = Random.Range(-17f, 17f);
                        Vector3 posicion = new Vector3(enemy1X, 50, -3);
                        GameObject go1 = Instantiate(enemy1, posicion, Quaternion.Euler(new Vector3(90, 0, 180)));
                        gameObject.transform.tag = "enemy";
                        break;
                    case 1:
                        enemy2X = Random.Range(17f, -17f);
                        Vector3 posicion2 = new Vector3(enemy2X, 50, -3);
                        GameObject go2 = Instantiate(enemy2, posicion2, Quaternion.Euler(new Vector3(90, 0, 180)));
                        gameObject.transform.tag = "enemy";

                        break;
                    case 2:
                        minax = Random.Range(-17f, 17f);
                        Vector3 posicion3 = new Vector3(minax, 50, -3);
                        GameObject go3 = Instantiate(mina, posicion3, Quaternion.Euler(new Vector3(90, 0, 180)));
                        gameObject.transform.tag = "enemy";

                        break;
                }
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    
}
