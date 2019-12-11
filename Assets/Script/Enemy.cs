using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

    public DatoEnemi datoEnemi;
    GameObject go1= null;
    GameObject go2= null;
    GameObject go3= null;
    GameObject bos= null;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject mina;
    public GameObject warningBoss;

    public static bool juego = true;
    public float enemy1X;
    public float enemy2X;
    public static int boss=200;
    float minax;
   
    void Start()
    {
        StartCoroutine(Spaun());
    }
    public struct DatoEnemi
    {
        public int health;
        public int attack;
    }
    IEnumerator Spaun()
    {
        while(juego== true)
        {
            int numEnemi = UnityEngine.Random.Range(1, 4);
            for (int i = 0; i < numEnemi; i++)
            {
                int enemy = UnityEngine.Random.Range(0, 3);
                switch(enemy)
                {
                    case 0:
                        enemy1X = UnityEngine.Random.Range(-17f, 17f);
                        Vector3 posicion = new Vector3(enemy1X, 50, -3);
                        go1 = Instantiate(enemy1, posicion, Quaternion.Euler(new Vector3(90, 0, 180)));
                        gameObject.transform.tag = "enemy";
                        break;
                    case 1:
                        enemy2X = UnityEngine.Random.Range(17f, -17f);
                        Vector3 posicion2 = new Vector3(enemy2X, 50, -3);
                        go2 = Instantiate(enemy2, posicion2, Quaternion.Euler(new Vector3(90, 0, 180)));
                        gameObject.transform.tag = "enemy";

                        break;
                    case 2:
                        minax = UnityEngine.Random.Range(-17f, 17f);
                        Vector3 posicion3 = new Vector3(minax, 50, -3);
                        go3 = Instantiate(mina, posicion3, Quaternion.Euler(new Vector3(90, 0, 180)));
                        gameObject.transform.tag = "enemy";

                        break;
                }
            }
            if (boss == 0)
            {juego= false;
             Boss();
            }
            yield return new WaitForSeconds(2f);
        }

    }

    private void Boss()
    {
        
    }
}
