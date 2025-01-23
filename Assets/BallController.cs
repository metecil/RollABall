using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    void Start()
    
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Calling the Update method");
        Vector2 inputVector = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        
        // (same input checks as above)

        // Convert (x,y) to (x,0,z) in 3D
        Vector3 inputXZPlane = new(inputVector.x, 0, inputVector.y);

        // Apply force to the rigidbody
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
