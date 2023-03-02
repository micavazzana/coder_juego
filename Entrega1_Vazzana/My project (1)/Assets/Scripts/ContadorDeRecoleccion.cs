using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorDeRecoleccion : MonoBehaviour
{
    private int contadorDeGemas;

    void Start()
    {
        this.contadorDeGemas = 0;
    }
    public void Contador()
    {
        contadorDeGemas++;
        Debug.Log($"Sumaste una mas, {this.contadorDeGemas}");
        //Mostrar en la UI cuantas gemas van
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Gema"))
        {
            Contador();
        }
    }
}
