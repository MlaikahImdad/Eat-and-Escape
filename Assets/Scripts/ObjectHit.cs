using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] int deathHit = 0;
    Renderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Ground") && !other.gameObject.CompareTag("Bean"))
        {
            deathHit++;
            if (deathHit == 3)
            {
                myRenderer.material.color = Color.red;
            }
            if (deathHit == 4)
            {
                PlayerDeath();
            }
        }
    }

    void PlayerDeath()
    {
        Debug.Log("GAME OVER!\nTotal Scores = " + Scores.scores);
        gameObject.SetActive(false);
    }
}