using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            // Desactiva el BoxCollider
            BoxCollider boxCollider = GetComponent<BoxCollider>(); // Obtiene el componente BoxCollider del objeto
            if (boxCollider != null)
            {
                boxCollider.enabled = false; // Desactiva el BoxCollider
            }
        }

    }
}
