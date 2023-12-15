using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSender : MonoBehaviour
{
    public delegate void NewspaperCompany();
    public static event NewspaperCompany subscription;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(subscription != null)
            {
                Debug.Log("Event Happened");
                subscription();
            }
            else
            {
                Debug.Log("No subscribers");
            }
        }
    }
}
