using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourWine : MonoBehaviour
{
    public GameObject wineStream;
    public Transform wineBottle;
    public Transform bottleTop;

    private bool isPouring = false;
    private bool pourcheck;
    private float bottleTopHeight;
    private float bottleBotHeight;

    // Start is called before the first frame update
    void Update()
    {
        bottleBotHeight = wineBottle.position.y;
        bottleTopHeight = bottleTop.position.y;

        pourcheck = ((bottleBotHeight - bottleTopHeight) > 0);
        
        if (isPouring != pourcheck)
        {
            isPouring = pourcheck;
            wineStream.SetActive(isPouring);
        }
    }
}
