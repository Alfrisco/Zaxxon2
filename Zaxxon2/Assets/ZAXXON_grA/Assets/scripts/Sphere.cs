using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float speed = 2.5f;
    public GameObject Columna;
    private Columna columna;
    [SerializeField] Text speedText;
    [SerializeField] Text timeText;

    private string currentTime;
    public GameObject Nave;
    private Sphere sphere;
    public float mySpeed;

    // Start is called before the first frame update
    void Start()
    {
        Nave = GameObject.Find("Spaceship");
        sphere = Nave.GetComponent<Sphere>();
        mySpeed = sphere.speed;
    }

    // Update is called once per frame
    void Update()
    {

        MoverNave();

        if (speed < 50f)
        {
            speed = speed + 0.1f;
        }

        //Cambio el texto de la UI, metido en la variable speedText
        //Debe ser una cadena, si quiero`puedo convertir el float en string
        //speedText.text = speed.ToString();
        speedText.text = "Velocidad: " + speed + " Kmts/h";

        // Obtain the current time.
        currentTime = Time.time.ToString("f2");
        currentTime = "Time is: " + currentTime + " sec.";

        timeText.text = currentTime;

    }

    void MoverNave()
    {
        float PosX = transform.position.x;
        float PosY = transform.position.y;
        print(transform.position.x);
        float desplY = Input.GetAxis("Vertical");

        float desplX = Input.GetAxis("Horizontal");

        //Restringir movimiento horizontal
        if (PosX > 0 && PosX < 30)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        else if (PosX < 0 && desplX > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
        else if (PosX > 30 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //Restringir movimiento vertical
        if (PosY > 0 && PosY < 9)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        else if (PosY < 0 && desplY > 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }
        else if (PosY > 9 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        }



    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("objeto1 ha colisionado con objeto2");
        GameObject objeto1 = GameObject.Find("Spaceship");
        if (collision.gameObject.tag == "Respawn")
        {
            Debug.Log("objeto1 ha colisionado con objeto3");
            speed = 0f;
            Destroy(gameObject);
            print(columna.mySpeed);
        }

    }

}
