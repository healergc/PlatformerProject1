using UnityEngine;

public class NewLevelTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("I Have Found A Player")
        }
    }
}

