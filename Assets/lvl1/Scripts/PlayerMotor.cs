
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    private Rigidbody rb;
    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private Vector3 rotationCamera = Vector3.zero;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    public void Move(Vector3 velocity)
    {
        this.velocity = velocity;
    }
    private void FixedUpdate()
    {
        PerformMove();
        PerformRotation();
    }
    void PerformMove()
    {
        if (velocity != Vector3.zero)
            rb.MovePosition(rb.position + velocity * Time.fixedTime);
    }

    public void Rotate(Vector3 rotation)
    {
        this.rotation = rotation;
    }
    
    public void RotateCam(Vector3 rotationCamera)
    {
        this.rotationCamera = rotationCamera;
    }

    void PerformRotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
        if(cam !=null)
        {
            cam.transform.Rotate(-rotationCamera);
        }
    }

}
