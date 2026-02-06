using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering.UI;

public class InGameObjectMovement : MonoBehaviour
{
    // Z location where ships are yeeted into the distance
    // (past the player ship)
    public float telleportThreshold = -130.0f;
    // Object will appear here (on z axis) once move (yeeted)
    public float distanceOnHorizonToAppearZ = 100.0f;
    // Left and right limit for spaning
    public float MinDistanceSpawnX = -30.0f;
    public float MaxDistanceSpawnX = +30.0f;

    // This is our custom class that's on the GameManager game object
    public PointsManager ThePointsManager;

    public Vector3 Velocity = new Vector3(0.0f, 0.0f, -6.0f);    // Or Vector3.zero;
    void Start()
    {
        // Could give this a random seed
        //Random.InitState(65);
    }

    // Update is called once per frame
    void Update()
    {
//        Vector3 curPosition = transform.position;
//        curPosition.z += ( Velocity.z * Time.deltaTime);
//        transform.position = curPosition;

        // 1. Move it along the x
        // 2. Also, rotate it a degree per second
        // 3. Scale it 
        // 4. Also, move it in the direction it's facing

        // OR
        transform.Translate(0.0f, 0.0f, Velocity.z * Time.deltaTime);

        // Have I gone past where we can see the ship?
        // (was -130 when we eye-balled it) 
        if ( transform.position.z <= telleportThreshold)
        {
            Vector3 currentPosition = transform.position;

            currentPosition.z = distanceOnHorizonToAppearZ;

            // Random left and right position (on horizon)
            currentPosition.x 
                = Random.Range(MinDistanceSpawnX, MaxDistanceSpawnX);

            transform.position = currentPosition;

            // Also score some points
            ThePointsManager.AddPoints(10);

        }

    }
}
