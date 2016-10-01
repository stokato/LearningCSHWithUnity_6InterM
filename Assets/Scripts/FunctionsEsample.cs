using UnityEngine;
using System.Collections;

public class FunctionsEsample : MonoBehaviour {

    int a = 0;

	// Use this for initialization
	void Start () {
        print(a);
        SetA(3);
        print(a);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void SetA (int i)
    {
        a = i;
    }
}
