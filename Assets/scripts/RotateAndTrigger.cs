using UnityEngine;

public class RotateAndTrigger : MonoBehaviour
{
    public Transform target; // The object to rotate around
    public float speed = 50f; // Rotation speed
    public Vector3 axis = Vector3.up; // Rotation axis

    public GameObject InactiveObject;

    void Update()
    {
        if (target != null)
        {
            transform.RotateAround(target.position, axis, speed * Time.deltaTime);
        }
    }
private void OnTriggerEnter(Collider other){

    gameObject.SetActive(false);
    InactiveObject.SetActive(true);
}

}
