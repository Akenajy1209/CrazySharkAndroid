using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BalaMov : MonoBehaviour
{
    public float velMovBala=2f;
    private float tiempo=0.5f;
    // AudioSource audio;
    private void Start()
    {
        //audio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {

        //Se traslada en su eje Z positivo
        transform.Translate(Vector3.down * velMovBala * Time.deltaTime);
        tiempo -= Time.deltaTime;
        if(transform.position.y < -13f)
        {
            Destroy(gameObject);
        }

    }
    
}
