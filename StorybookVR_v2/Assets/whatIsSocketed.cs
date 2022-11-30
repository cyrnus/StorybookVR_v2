using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class whatIsSocketed : MonoBehaviour
{
    List<IXRSelectInteractable> itemInSocket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<XRSocketInteractor>().hasSelection)
        {
            itemInSocket = gameObject.GetComponent<XRSocketInteractor>().interactablesSelected;
            Debug.Log("Socket holds: " + itemInSocket[0].transform.name);
        } else
        {
            Debug.Log("Socket is Empty");
        }
    }
}
