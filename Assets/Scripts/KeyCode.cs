using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCode : MonoBehaviour
{
    public GameObject Door;
    public GameObject FakeWall;
    public GameObject FakeWall1;
    public GameObject FakeWall2;
    public GameObject FakeWall3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(Door);
        Destroy(FakeWall);
        Destroy(FakeWall1);
        Destroy(FakeWall2);
        Destroy(FakeWall3);
    }

}
