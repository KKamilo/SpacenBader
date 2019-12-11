using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBoosIA : MonoBehaviour
{
    public TextMeshProUGUI textBoss;


    void Update()
    {
        textBoss.text= "Boss en = "+ Enemy.boss;
    }
}
