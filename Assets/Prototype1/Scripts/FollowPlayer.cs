using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 6, -9);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame AFTER the Update method runs
    void LateUpdate()
    {
        //offset the camera behind the player by adding cameraOffset at the player position
        transform.position = player.transform.position + cameraOffset;
    }
}
