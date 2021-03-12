using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartController : MonoBehaviour
{
    public Rigidbody dartRB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DartBoard"))
        {
            collision.gameObject.GetComponent<DartBoardRegion>().OnRayHit();
            dartRB.isKinematic = true;
            dartRB.useGravity = false;
            StartCoroutine(RespawnDart(5.0f));
            Debug.Log("Hit Dart Board");
        }
    }
    //private void OnTriggerEnter2d (Collider24 other)
    //{
    //    
    //}

    //void ColliderFinder()
    //{
    //    RaycastHit hit;
    //    if (Physics.Raycast(transform.position,transform.forward, out hit))
    //    {
    //        Debug.DrawRay(transform.position, transform.forward);
    //        if (hit.collider != null)
    //        {
    //            var hitReceiver = hit.collider.gameObject.GetComponent<DartBoardRegion>();
    //            if (hitReceiver != null)
    //            {
    //                hitReceiver.OnRayHit();
    //            }
    //        }
    //    }
    //}


    private IEnumerator RespawnDart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        dartRB.isKinematic = false;
        dartRB.useGravity = true;
        dartRB.gameObject.transform.position = new Vector3(0, 1, 0.5f);
    }
}
