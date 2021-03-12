using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartController : MonoBehaviour
{
    private Rigidbody dartRB;
    // Start is called before the first frame update
    void Start()
    {
        dartRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DartBoard"))
        {
            dartRB.isKinematic = true;
            dartRB.useGravity = false;
            Debug.Log("Hit Dart Board");
        }
    }
}
