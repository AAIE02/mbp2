using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STOPWATCH : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text time;

    private float restante;
    private bool enMarcha;

    private void Awake()
    {
        restante = (min * 60) + seg;
        enMarcha = true;
    }
    void Update()
    {
        if(enMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                enMarcha = false;
                Player.MuerteCrono = true;
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            time.text = string.Format("{00:00} : {01:00}", tempMin, tempSeg);
        }
    }
}
