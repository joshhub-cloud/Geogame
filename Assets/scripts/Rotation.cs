using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform target; // The object to rotate around
    public float speed = 10f; // Rotation speed
    public Vector3 axis = Vector3.up; // Rotation axis

    void Update()
    {
        if (target != null)
        {
            transform.RotateAround(target.position, axis, speed * Time.deltaTime);
        }
    }

    
}
