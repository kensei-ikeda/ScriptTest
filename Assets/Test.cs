using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    
    void Start()
    {
        //要素が5個この配列array
        int[] array = new int[5];
        
        //5個の要素を初期化
        array [0] = 89;
        array [1] = 76;
        array[2] = 82;
        array[3] = 22;
        array[4] = 99;

        //配列の要素を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //配列を逆順に表示
        for (int k = 4; k >= 0; k--)
        {
            Debug.Log(array[k]);
        }
     }
    // Update is called once per frame
    void Update () {
		
	}
}
