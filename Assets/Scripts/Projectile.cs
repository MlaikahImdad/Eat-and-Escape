using UnityEditor.Callbacks;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    [SerializeField] float chaseDuration = 15f;
    [SerializeField] Transform player;

    Rigidbody rb;

    Vector3 playerPosition;
    Vector3 permanentPosition;
    float chaseTime;
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        permanentPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        chaseTime = chaseDuration;
    }
    void Update()
    {
        playerPosition = player.transform.position;
        MoveToPlayer();
        DestroyWhenReached();
    }
    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
    void DestroyWhenReached()
    {
        chaseTime -= Time.deltaTime;
        if (Vector3.Distance(transform.position, playerPosition) < 1f)
        {
            ResetProjectile();
        }
        else if (chaseTime <= 0f)
        {
            ResetProjectile();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        rb.constraints = RigidbodyConstraints.FreezePositionY;
    }

    void ResetProjectile()
    {
        transform.position = permanentPosition;
        gameObject.SetActive(false);
    }
}