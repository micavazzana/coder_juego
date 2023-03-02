using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float cantidadDeVida;

    private void Start()
    {
        this.cantidadDeVida = 3f;
    }
    private void Update()
    {
        if (cantidadDeVida <= 0)
        {
            GameOver.Game_Over();
        }
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.CompareTag("Enemigo"))
        {
            cantidadDeVida -= 0.5f;
            Debug.Log($"Perdiste medio corazon, te quedan: {this.cantidadDeVida}");
            //Mostrar en la UI cuantos corazones van quedando
        }
    }
}
