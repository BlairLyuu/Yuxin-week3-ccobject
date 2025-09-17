using UnityEngine;

public class CameraTriggerEnd : MonoBehaviour
{
    public Camera fromCamera;
    public Camera toCamera;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Domino")) 
        {
            if (fromCamera != null)
            {
                fromCamera.enabled = false;
                fromCamera.gameObject.SetActive(false);
            }

            if (toCamera != null)
            {
                toCamera.gameObject.SetActive(true);
                toCamera.enabled = true;
            }
        }
    }
}