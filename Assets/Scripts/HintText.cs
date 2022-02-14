using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintText : MonoBehaviour
{
    public GameObject Collider;
    public GameObject hintText;
    // Start is called before the first frame update
    void Start()
    {
        hintText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter(Collider Collider)
    {
        hintText.SetActive(true);
    }
    private void OnTriggerExit(Collider Collider)
    {
        hintText.SetActive(false);
    }
}
