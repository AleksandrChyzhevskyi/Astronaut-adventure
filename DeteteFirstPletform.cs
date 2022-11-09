using UnityEngine;

public class DeteteFirstPletform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        Destroy(transform.parent.gameObject);
    }
}
