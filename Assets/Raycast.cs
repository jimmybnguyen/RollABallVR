using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {
    public LayerMask layerMask;
    public Rigidbody rb;
    public float speed;

    // Use this for initialization
    void Start () {

    }
	
    void FixedUpdate()
    {
        RaycastHit hit;
        if (!Physics.Raycast(transform.position, transform.forward, out hit, layerMask))
        {
            return;
        }
        if (rb != null)
        {
            Vector3 target = new Vector3(hit.point.x, 0.0f, hit.point.z);
            Vector3 direction = (target - rb.position).normalized * speed;
            rb.velocity = direction;
        }
    }
}
