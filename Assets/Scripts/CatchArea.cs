using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchArea : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Fish fish = other.GetComponent<Fish>();
        if (fish != null)
        {
            Fishing fishing = FindObjectOfType<Fishing>();
            if (fishing != null && fishing.GetIsHooked())
            {
                // Call the ResetHook method here and check if the hook was reset
                if (fishing.ResetHook())
                {
                    // Add code here to display the details of the fish on the UI
                    Debug.Log("Caught a fish!");
                    Debug.Log("Weight: " + fish.weight);
                    Debug.Log("Name: " + fish.fishName);
                    Debug.Log("Description: " + fish.description);
                    Destroy(fish.gameObject);
                }
            }
        }
    }
}
