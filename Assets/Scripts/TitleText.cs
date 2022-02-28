using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleText : MonoBehaviour
{
    private float positionX;
    private float positionY;
    public GameObject titleText;

   void FixedUpdate()
    {
        if (positionX != -9.8 || positionY != 0)
        {
            titleText.SetActive(false);
        }
    }

    private void Start()
    {
        titleText.SetActive(true);
    }
}
