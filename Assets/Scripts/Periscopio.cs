using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Periscopio : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        float gyroX = -Input.gyro.rotationRateUnbiased.z;

        // Obt�n la aceleraci�n en el eje X utilizando el aceler�metro
        float accelX = Input.acceleration.z;

        // Puedes ajustar la velocidad de movimiento aqu�
        float movementSpeed = 5.0f;

        // Calcula la velocidad de movimiento combinando el giroscopio y el aceler�metro
        float combinedSpeed = gyroX + accelX;

        // Calcula la nueva posici�n en funci�n de la velocidad
        Vector3 newPosition = transform.position + new Vector3(combinedSpeed * movementSpeed * Time.deltaTime, 0, 0);

        // Limita la posici�n en el eje X para evitar que el objeto salga de la pantalla
        float minX = -2.4f; // Establece el valor m�nimo
        float maxX = 2.4f;  // Establece el valor m�ximo
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        // Establece la nueva posici�n del objeto
        transform.position = newPosition;
    }
}
