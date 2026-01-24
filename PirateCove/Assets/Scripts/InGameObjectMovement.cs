using UnityEngine;
using UnityEngine.Rendering.UI;

public class InGameObjectMovement : MonoBehaviour
{
    public Vector3 Velocity = new Vector3(0.0f, 0.0f, -3.0f);    // Or Vector3.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curPosition = transform.position;
        curPosition.z += ( Velocity.z * Time.deltaTime);
        transform.position = curPosition;


    }
}
