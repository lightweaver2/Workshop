using UnityEngine;
using System.Collections;

public class DemoScript2 : MonoBehaviour {

    public Light myLight;

    void Update () {
        if (Input.GetKeyDown ("space")) {
            myLight.enabled = true;
        }

        if (Input.GetKeyUp ("space")) {
            myLight.enabled = false;
        }
    }
}