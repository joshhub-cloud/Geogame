using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController_Script : MonoBehaviour
{
    // ------ COMPLETE -------

    public float speed;
    public float mouseSensitivity;
    public float scaleStep; 

    private float rotationX = 0f;
    private float rotationY = 0f;

    public Text textPosition;
    public Text textRotation;
    public Text textScale;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Bloquea el cursor en el centro de la pantalla
        Cursor.visible = false; // Oculta el cursor
    }

    // Update is called once per frame
    void Update()
    {
        //-----COMPLETE-----
        
        // Movimiento del personaje con WASD
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(moveX, 0, moveZ);

        // Rotación con el mouse
        rotationX += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationY -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f); // Limita la rotación vertical
        transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);

        if (Input.GetKeyDown(KeyCode.P)) // Aumentar escala
        {
            transform.localScale += Vector3.one * scaleStep;
        }

        if (Input.GetKeyDown(KeyCode.M)) // Disminuir escala
        {
            transform.localScale -= Vector3.one * scaleStep;
            transform.localScale = new Vector3(Mathf.Max(transform.localScale.x, 0.2f),
                                               Mathf.Max(transform.localScale.y, 0.2f),
                                               Mathf.Max(transform.localScale.z, 0.2f)); // Evita que la escala sea menor a 0.2
        }
        if (textPosition != null && textRotation != null && textScale != null)
        {
            textPosition.text = $"Posición \nX:{transform.position.x:F2} \nY:{transform.position.y:F2} \nZ:{transform.position.z:F2}";
            textRotation.text = $"Rotacion \nX:{transform.rotation.x:F2} \nY:{transform.rotation.y:F2} \nZ:{transform.rotation.z:F2}";
            textScale.text = $"Escala \nX:{transform.localScale.x:F2} \nY:{transform.localScale.y:F2} \nZ:{transform.localScale.z:F2}";
        }
    }  

    // ----- COMPLETE ------

   
}
