using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestReciever : MonoBehaviour
{
    void NewspaperReciever()
    {
        Debug.Log("Event Heard");
    }

    void OnEnable()
    {
        TestSender.subscription += NewspaperReciever;
    }

    void OnDisable()
    {
        TestSender.subscription -= NewspaperReciever;
    }
}
