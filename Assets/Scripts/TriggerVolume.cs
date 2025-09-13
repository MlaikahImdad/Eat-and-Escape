using UnityEngine;

public class TriiggerVolume : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    // [SerializeField] GameObject projectile3;
    void Start()
    {
        
    }

    bool hasTriggered = false;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player" && !hasTriggered)
        {
            projectile.SetActive(true);
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            // projectile3.SetActive(true);
            
            hasTriggered = true;
        }
    }
}
