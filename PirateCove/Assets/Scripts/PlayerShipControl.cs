using UnityEngine;

public class PlayerShipControl : MonoBehaviour
{
    public Vector3 shipVelocity = new Vector3(0.0f, 0.0f, 0.0f);    // Or Vector3.zero;
    public float steeringForce = 1.0f;
//    [SerializeField]
//    private int age = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);

        Vector3 curPos = transform.position;

        // How much THIS FRAME do I apply?
        float forceThisFrame = steeringForce * Time.deltaTime;

        // Go left! Port!!
        if ( Input.GetKey(KeyCode.A) )
        {
            //curPos.x -= shipVelocity.x;  
            shipVelocity.x += forceThisFrame;
        }
        // Go right! Starboard!
        if ( Input.GetKey(KeyCode.D) )
        {
            //curPos.x += shipVelocity.x;
            shipVelocity.x -= forceThisFrame;
        }

        // TODO: Limit the velocy to something reasonable
        //if ( shipVelocity.x > 1.0f ) { shipVelocity.x = 1.0f; }

        //transform.position = curPos;
        transform.position += shipVelocity;
    }
}
