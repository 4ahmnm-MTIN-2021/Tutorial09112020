using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorTypes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyMethode();
        Debug.Log(MyMethodeAdd() + MyMethodeAdd());
    }

    // Update is called once per frame
    void Update()
    {
        //MyMethode();
    }

    void MyMethode()
    {
        Debug.Log("Hello Joe");
    }

    int MyMethodeAdd()
    {
        return 5;
    }

    string MyMethodeString()
    {
        return "";
    }
}
