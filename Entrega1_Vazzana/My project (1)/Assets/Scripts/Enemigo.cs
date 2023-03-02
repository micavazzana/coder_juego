using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public GameObject player;
    public GameObject enemigo;
    public float velocidadDeMovimiento;
    public float stopDistance;
    float distancia;

    void Start()
    {
        this.velocidadDeMovimiento = 2.0f;
    }
    void Update()
    {
        MoverPersonajeLerp(player, enemigo);
    }
    
    public void MoverPersonajeLerp(GameObject p, GameObject e)
    {

        this.distancia = Vector3.Distance(p.transform.position, e.transform.position);
        if (this.distancia <= this.stopDistance)
        {
            this.velocidadDeMovimiento = 0;
        }
        else
        {
            this.velocidadDeMovimiento = 1f;
        }
        
        e.transform.position = Vector3.Lerp(e.transform.position, p.transform.position, Time.deltaTime * this.velocidadDeMovimiento);
    }
}

