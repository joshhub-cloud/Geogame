using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Script : MonoBehaviour
{
    private RaycastHit hit;
    public float rayDistance = 10f; // Length of the Ray
    public Color rayColor = Color.red; // Color of the Ray

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = transform.forward;
        Debug.DrawRay(transform.position, direction * rayDistance, rayColor);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        // ------ COMPLETE -------

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hola");
            }
        }

    }
}
