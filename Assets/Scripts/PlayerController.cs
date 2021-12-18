using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10;
    [SerializeField] private float rotateSpeed = 75;
    //[SerializeField] private float jumpForce = 5;
    //[SerializeField] private KeyCode keyJump = KeyCode.Space;
    //[SerializeField] private float distanceFromGround = 0.1f;
    //[SerializeField] private LayerMask groundLayer;

    private const string VERTICAL_AXIS = "Vertical";
    private const string HORIZPNTAL_AXIS = "Horizontal";

    private float vInput;
    private float hInput;
    private Rigidbody rb;
    //private bool canJump = false;
    private BoxCollider boxCollider;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        vInput = Input.GetAxis(VERTICAL_AXIS) * moveSpeed;
        hInput = Input.GetAxis(HORIZPNTAL_AXIS) * rotateSpeed;

        //if (Input.GetKeyDown(keyJump))
        //{
        //    canJump = true;
        //}
    }

        //private void FixedUpdate()
        //{
        //    if (canJump /*&& IsGrounded*/())
        //    {
        //        canJump = false;
        //        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //    }
            
        //    Vector3 rotation = Vector3.up * hInput;
        //    Quaternion angelRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        //    rb.MovePosition(transform.position + transform.forward * vInput * Time.fixedDeltaTime);
        //    rb.MoveRotation(rb.rotation * angelRot);
        //}

    //private bool IsGrounded()
    //{
    //    Vector3 capsuleBottom =
    //        new Vector3(boxCollider.center.x, boxCollider.bounds.min.y, boxCollider.center.z);

    //    bool isGrounded = Physics.CheckCapsule(boxCollider.bounds.center, capsuleBottom, distanceFromGround,
    //        groundLayer, QueryTriggerInteraction.Ignore);

    //    return isGrounded;
    //}

}

