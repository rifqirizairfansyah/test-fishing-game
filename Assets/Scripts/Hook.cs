using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        CatchArea catchArea = other.GetComponent<CatchArea>();
        if (catchArea != null)
        {
            // Add code here to handle when the hook enters the catch area
            Debug.Log("Hook entered catch area");
        }
    }
}
