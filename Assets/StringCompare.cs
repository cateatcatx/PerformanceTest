using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringCompare : MonoBehaviour {

    private string abc = "abc";
    private bool isTrue;

	// Use this for initialization
	void Start () {
		isTrue = abc == "abc";
	}
}
