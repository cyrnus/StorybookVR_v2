using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAxe : MonoBehaviour
{
    public GameObject fireAxePrefab;

    public void CreateFireAxe()
    {
        GameObject newAxe = Instantiate(fireAxePrefab, transform.position, transform.rotation);
    }
}
