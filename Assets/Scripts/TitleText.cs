using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float movementX;
    private float movementY;
    public GameObject TitleText;
    void FixedUpdate()
    {
        if (movementX > 0 || movementY > 0 || movementX < 0 || movementY < 0)
        {
            TitleText.SetActive(false);
        }
    }

    
}
