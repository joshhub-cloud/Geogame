using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Script : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject Door;
    public string targetTag = "Victim";

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.CompareTag("Victim"))
                {
                    if (Door != null)
                    {
                        Door.SetActive(true);
                    }
                    Destroy(hit.transform.gameObject);
                }


            }
        }
    }
}
