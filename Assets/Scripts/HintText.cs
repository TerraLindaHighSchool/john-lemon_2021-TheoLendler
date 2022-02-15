using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintText : MonoBehaviour
{
    public GameObject Collider;
    public GameObject hintText;
    public bool hasKey;
    // Start is called before the first frame update
    void Start()
    {
        hintText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !hasKey) hintText.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") hintText.SetActive(false);
    }
}
