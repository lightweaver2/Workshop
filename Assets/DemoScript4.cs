using UnityEngine;
using System.Collections;

public class DemoScript4 : MonoBehaviour {

    public Light myLight;

    void Update () {
        if (Input.GetKeyDown ("space")) {
            MyFunction ();
        }
    }

    void MyFunction () {
        myLight.enabled = !myLight.enabled;
    }
}