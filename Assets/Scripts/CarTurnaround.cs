
using UnityEngine;

public class CarTurnaround : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            var carBehave = other.GetComponent<CarBehavior>();
            carBehave.enabled = false;
        }
    }
}
