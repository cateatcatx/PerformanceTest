using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{	
    List<int> list = new List<int>();

	// Update is called once per frame
	void Update () {
        int t = 0;
		foreach (int i in list)
        {
            t += i;
        }
	}
}
