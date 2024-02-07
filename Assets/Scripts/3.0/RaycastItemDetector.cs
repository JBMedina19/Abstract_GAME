using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastItemDetector : MonoBehaviour
{
    public float detectionRange = 5.0f;
    public LayerMask itemLayerMask;
    private ItemCollector itemCollector;

    void Update()
    {
            DetectItem();
    }

    void DetectItem()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit, detectionRange, itemLayerMask))
        {
            Debug.Log("Item detected: " + hit.collider.gameObject.name);

            // Add additional logic here, like collecting the item
        }
        if (Input.GetKeyDown(KeyCode.E)) // Assuming 'E' is the key to interact
        {
            hit.collider.gameObject.GetComponent<CollectibleItem>().CollectItem();
        }

    }

    void OnDrawGizmos()
    {
        // Optional: Draw the ray in the scene view for debugging purposes
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * detectionRange);
    }
}