using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; //controls the speed of the player movement
    Rigidbody rb; //letting the script know that there is a rigidbody. Using variable name rb for referencing it in further script

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //rb = the rigidbody of the player
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); //d key changes value to 1, a key changes value to -1
        float zMove = Input.GetAxisRaw("Vertical"); //w key changes value to 1, s key changes to value -1

        rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed; //creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling  + jumping by setting velocity to y.

    }
}
