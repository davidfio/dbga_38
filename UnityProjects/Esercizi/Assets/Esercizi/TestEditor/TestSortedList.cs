using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestSortedList : MonoBehaviour {


    public enum MyEnum
    {
        Uno,
        Due,
        Tre

    }


	void Start ()
    {
        SortedList<MyEnum, string> mySortedList = new SortedList<MyEnum, string>();

        // Aggiungo dei valori
        mySortedList.Add(MyEnum.Due, "Due");
        mySortedList.Add(MyEnum.Tre, "Tre");
        mySortedList[MyEnum.Uno] = "Uno";

        // Cicliamo sui valori
        // Debug.Log("Index of Uno " + mySortedList.IndexOfKey(MyEnum.Uno));

        foreach (var pair in mySortedList)
        {
            Debug.Log("K: " + pair.Key + " V: " + pair.Value);
        }

        var k = mySortedList.Keys[2];
        Debug.Log(k);
	
	}
	

	void Update ()
    {
	
	}
}
