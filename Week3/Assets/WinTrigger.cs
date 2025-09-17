using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winText;   // ÍÏÄãµÄ ¡°CONGRATULATIONS! YOU WIN¡± UI

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Domino"))
        {
            if (winText != null)
                winText.SetActive(true);
        }
    }
}
