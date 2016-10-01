using UnityEngine;
using System.Collections;

public class Second : MonoBehaviour {

    void Awake()
    {
        Debug.Log("Second Awake Start");
    }   

    void OnEnable()
    {
        Debug.Log("Second OnEnable Start");
    }

}
