using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public float flotantePublico = 0.1f;
    private float flotantePrivado = 0.1f;
    [SerializeField] private float flotantePrivadoSerializeField = 0.1f;
    private bool isWorking = true;
    private Rigidbody rb;
    

    // Metodo que se ejecuta antes de iniciar el juego
    void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola Mundo muchas veces");
        CrearRayCast();
    }

    // Este es un metodo que trabaja con las fisicas de unity
    void FixedUpdate()
    {
        AgregarUnaFuerza();

    }


    // Detecta cuando una colision se acaba de producir
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Estoy colisionando con un objeto cualquiera");

        if (other.gameObject.CompareTag("Suelo")) 
        {
            Debug.Log("Hey, Colisione con el suelo");
        }
    }

    // Detecta cuando una colision se produce constantemente
    private void OnCollisionStay(Collision other)
    {
        Debug.Log("Me mantengo colisionando con un objeto cualquiera");

        if (other.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("Me mantengo colisionando con el suelo");
        }

    }

    // Detecta cuando una colision deje de producirse
    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Sali de la colision con un objeto cualquiera");

        if (other.gameObject.CompareTag("Suelo"))
        {
            Debug.Log("Deje de colisionar con el suelo");
        }

    }

    // Gatilla de un evento cuando se produce una colision
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Suelo")) {
            Debug.Log("Hice una colision con el trigger");
        }
    }

    // Gatilla de un evento cuando se mantiene una colision
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Suelo")) {
            Debug.Log("Estoy manteniendome colisionando con el trigger");
        }
    }

    // Gatilla de un evento cuando se termina una colision
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Suelo")) {
            Debug.Log("Deje de hacer la colision con el trigger");
        }
    }

    public void AgregarUnaFuerza() 
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            // Agregamos una fuerza al RigidBody
            rb.AddForce(new Vector3(0,100,0), ForceMode.Force);
        }
    }

    public void CrearRayCast()
    {
        RaycastHit hit;
        Ray ray = new Ray (transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down);
    }
}
