using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
    }
    /*
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Mouse X"), 0.0f, Input.GetAxis("Mouse Y"));
        rb.AddForce(movement * speed);
    }
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 13)
        {
            winText.text = "You Win!";
        }
    }

}
