using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo 
{
    public float time = 120f;
    public float bonus = 60f;
    public void Temporizador()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
            Debug.Log($"Quedan: {this.time}");
        }   
        //Mostrar en la UI el tiempo que va quedando
        if (time == 0)
        {
            GameOver.Game_Over();
        }
    }

    public void Bonus()
    {
        time += bonus;
    }

}
