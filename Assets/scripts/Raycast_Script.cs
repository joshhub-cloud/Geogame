using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Script : MonoBehaviour
{
    private RaycastHit hit;

    // Update is called once per frame
    void Update()
    {

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
