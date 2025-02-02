using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform teleportTarget; // Miejsce teleportacji

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Sprawdza, czy to gracz
        {
            CharacterController cc = other.GetComponent<CharacterController>();
            cc.enabled = false;
            other.transform.position = teleportTarget.position; // Teleportacja
            other.transform.rotation = teleportTarget.rotation;
            cc.enabled = true;
            //Debug.Log("Gracz teleportowany do: " + teleportTarget.position);
        }
    }
}
