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

        // Obtén la aceleración en el eje X utilizando el acelerómetro
        float accelX = Input.acceleration.z;

        // Puedes ajustar la velocidad de movimiento aquí
        float movementSpeed = 5.0f;

        // Calcula la velocidad de movimiento combinando el giroscopio y el acelerómetro
        float combinedSpeed = gyroX + accelX;

        // Calcula la nueva posición en función de la velocidad
        Vector3 newPosition = transform.position + new Vector3(combinedSpeed * movementSpeed * Time.deltaTime, 0, 0);

        // Limita la posición en el eje X para evitar que el objeto salga de la pantalla
        float minX = -2.4f; // Establece el valor mínimo
        float maxX = 2.4f;  // Establece el valor máximo
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        // Establece la nueva posición del objeto
        transform.position = newPosition;
    }
}
