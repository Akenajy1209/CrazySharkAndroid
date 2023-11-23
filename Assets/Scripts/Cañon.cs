using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject Carro1; //objeto que sera instanciado
    public GameObject Carro2;
    public GameObject Carro3;
    public GameObject Carro4;
    private GameObject InstanObjeto;
    public float tiempoMinInstancia = 2f; // Tiempo mínimo entre instancias
    public float tiempoMaxInstancia = 5f; // Tiempo máximo entre instancias
    [SerializeField]
    private float tiempoSigInstancia; // Tiempo restante hasta la próxima instancia
    //private Animator anim;

    //Sonido
    //private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        //audio = GetComponent<AudioSource>();
        tiempoSigInstancia = Random.Range(tiempoMinInstancia, tiempoMaxInstancia);
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        tiempoSigInstancia -= Time.deltaTime;

        if (tiempoSigInstancia <= 0f)
        {
            // Reiniciar el contador de tiempo para la próxima instancia
            tiempoSigInstancia = Random.Range(tiempoMinInstancia, tiempoMaxInstancia);
            //Debug.Log(tiempoSigInstancia);
            carroAleatorio();
            OnShoot();
        }
        // Restaurar la escala original después de realizar los cálculos y la instancia
        transform.localScale = Vector3.one;
    }
    public void OnShoot()
    {
        // Instanciar un objeto con la misma orientación
        Vector3 posicionInstancia = new Vector3(transform.position.x, transform.position.y-1, transform.position.z);
        Instantiate(InstanObjeto, posicionInstancia, transform.rotation);
        //Reproduce sonido de disparo
        //audio.Play();

    }
    public void carroAleatorio()
    {
        int numeroAleatorio = Random.Range(1, 5);
        switch (numeroAleatorio)
        {
            case 1:
                InstanObjeto = Carro1;
                break;
            case 2:
                InstanObjeto = Carro2;
                break;
            case 3:
                InstanObjeto = Carro3;
                break;
            case 4:
                InstanObjeto = Carro4;
                break;
            default:
                Debug.LogError("Número aleatorio fuera del rango esperado.");
                break;
        }
    }
    
}

