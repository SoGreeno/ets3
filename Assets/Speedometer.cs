using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI speedText;
    public Rigidbody rb;
    public float maxSpeed = 90f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        speed = rb.velocity.magnitude;
        speedText.text = speed.ToString("F0") + " km/h";
        if (speed > maxSpeed)
        {
            speedText.color = Color.red;
        }
        else
        {
            speedText.color = Color.white;
        }
    }
}
