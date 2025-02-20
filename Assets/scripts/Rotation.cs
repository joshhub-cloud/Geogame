using UnityEngine;

public class RotateAndTrigger : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation
    public GameObject objectToActivate; // Object to activate on trigger

    void Update()
    {
        // Rotate the object around its Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Activate the specified object
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
            }
            
            // Destroy this object
            Destroy(gameObject);
        }
    }
}
