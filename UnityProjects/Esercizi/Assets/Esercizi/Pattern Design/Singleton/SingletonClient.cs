using UnityEngine;
using System.Collections;

public class SingletonClient : MonoBehaviour {

    SingletonTest mySingleton;

    void Start ()
    {
        mySingleton = SingletonTest.GetIstance();
        mySingleton.DoStuff();

        SingletonMonoTest myMonoSingleTest = SingletonMonoTest.GetInstance();
	}
}
