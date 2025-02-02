using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    public float rayDistance = 10f; // Adjust this for raycast length
    public LayerMask layerMask; // Optional: Set this in the Inspector to filter layers

    void Update()
    {
        // Get the center of the screen
        Vector3 rayOrigin = transform.position;
        Vector3 rayDirection = transform.forward;

        // Perform the raycast
        if (Physics.Raycast(rayOrigin, rayDirection, out RaycastHit hit, rayDistance, layerMask))
        {
            Debug.Log("Hit: " + hit.collider.name);
            
            // Example: If you want to interact with an object
            if (hit.collider.CompareTag("Interactable"))
            {
                // Call some function on the hit object
                Debug.Log("Interactable Object Found!");
            }
            /* else if (hit.collider.CompareTag("Interactable"))
            {
                // Call some function on the hit object
                Debug.Log("Interactable Object Found!");
            }*/
        }

        // Optional: Debug Ray in Scene View
        Debug.DrawRay(rayOrigin, rayDirection * rayDistance, Color.red);
    }
}