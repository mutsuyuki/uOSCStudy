using uOSC;
using UnityEngine;

[RequireComponent(typeof(uOscServer))]
public class RecieveTest : MonoBehaviour {
    void Start() {
        var server = GetComponent<uOscServer>();

        server.onDataReceived.AddListener(message => {
            Vector3 pos = transform.position;
            pos.x = (float) message.values[0];
            pos.y = (float) message.values[1];
            transform.position = pos;


            Debug.Log(
                message.address + ":"
            );
        });
    }
}