using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerBehaviour : MonoBehaviour
{
    public int vidaMax;
    public float vidaActual;
    public Image ImagenBarraVida;
    public float velocidadMovimiento = 5f;
    //Sonido
    //public AudioClip sonidoDano;
    //public AudioClip sonidoMuerte;
    private AudioSource audio;


    private void Start()
    {
        //Datos = GameObject.FindWithTag("Player").GetComponent<PositionBehavier>();
        //DatosTiempo = GameObject.FindWithTag("Player").GetComponent<TimeController>();
        vidaActual = vidaMax;
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        RevisarVida();

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidadMovimiento * Time.deltaTime);
        }

        // Mover a la derecha
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidadMovimiento * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dano"))
        {
            //ReproducirSonido(sonidoDano);
            audio.Play();
            vidaActual -= 100;
            if (vidaActual <= 0)
            {
                //ReproducirSonido(sonidoMuerte);
            }
        }
    }
    public void RevisarVida()
    {
        ImagenBarraVida.fillAmount = vidaActual / vidaMax;
    }
    public void ReproducirSonido(AudioClip clip)
    {
        GetComponent<AudioSource>().clip = clip;
        GetComponent<AudioSource>().Play();
    }
}

