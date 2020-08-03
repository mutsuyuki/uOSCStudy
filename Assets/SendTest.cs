using uOSC;
using UnityEngine;

[RequireComponent(typeof(uOscClient))]
public class SendTest : MonoBehaviour {
    void Update() {
        var client = GetComponent<uOscClient>();

        object[] data = new object[2] {
            Mathf.Sin((float) Time.frameCount / 10f),
            Mathf.Sin((float) Time.frameCount / 5f) * 2.0f
        };

        client.Send("/testsend", data);
    }
}