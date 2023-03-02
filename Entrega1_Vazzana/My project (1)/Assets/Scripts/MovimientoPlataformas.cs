using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataformas : MonoBehaviour
{
    public float velocidadDeMovimiento;
    public float limiteSuperior;
    public float limiteInferior;
    private Vector3 direccion;

    void Start()
    {
        this.direccion = Vector3.up;
    }


    void Update()
    {
        MovimientoUpDown();
    }

    void MovimientoUpDown()
    {
        if(transform.position.y >= this.limiteSuperior)
        {
            this.direccion = Vector3.down;
        }
        else if(transform.position.y <= this.limiteInferior)
        {
            this.direccion = Vector3.up;
        }

        transform.Translate(this.direccion * velocidadDeMovimiento * Time.deltaTime);
    }

}
