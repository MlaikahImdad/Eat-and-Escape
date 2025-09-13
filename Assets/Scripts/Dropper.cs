using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] float distance = 8f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    Vector3 playerPosition;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;   
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position;
        if (Vector3.Distance(transform.position, playerPosition) < distance)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }   
    }
}
