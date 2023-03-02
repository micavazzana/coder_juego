using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorGemas : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            Destroy(this.gameObject);
        }
    }
}
