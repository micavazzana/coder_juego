using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidadDeMovimiento;
    public float velocidadDeRotacion;
    public float powerSalto;
    private Rigidbody rb;
    public Animator anim;
    private bool estaEnPiso;
    Tiempo t = new Tiempo();

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        estaEnPiso = true;
       // t = new Tiempo();
    }

    void FixedUpdate()
    {
        Movimiento();
        Salto();
        if (transform.position.y < -1)
        {
            GameOver.Game_Over();
        }
        t.Temporizador();
    }

    void Movimiento()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(horizontal, 0.0f, vertical);
        if (horizontal != 0 || vertical != 0)
        {
            anim.SetFloat("ejeHorizontal", horizontal);
            anim.SetFloat("ejeVertical", vertical);
        }

        //rb.AddForce(movimiento * velocidadDeMovimiento * Time.deltaTime);

        transform.Translate(movimiento * this.velocidadDeMovimiento * Time.deltaTime);
        transform.Rotate(0, horizontal * velocidadDeRotacion * Time.deltaTime, 0);
    }

    void Salto()
    {
        if (Input.GetKey(KeyCode.Space) && estaEnPiso)
        {
            estaEnPiso = false;
            anim.SetBool("estaSaltando", true);
            rb.AddForce(new Vector3(0, powerSalto, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            estaEnPiso = true;
            anim.SetBool("estaSaltando", false);
        }
        if(collision.gameObject.name == "PowerUp")
        {
            t.Bonus();
            Debug.Log("Sumaste bonus");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Portal")
        {
            Debug.Log("Pasaste de nivel");
            //Pasa a otra escena
        }
    }    
}
