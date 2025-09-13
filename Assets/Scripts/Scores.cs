using UnityEngine;

public class Scores : MonoBehaviour
{
    // Renderer myRenderer;
    public static int scores = 0;

    // void Start()
    // {
    //     myRenderer = GetComponent<Renderer>();
    // }
    // void Update()
    // {
    //     PlayerDeath();
    // }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bean")
        {
            scores++;
            Debug.Log("No. of beans you've eaten = " + scores);
        }
    }

    // void PlayerDeath()
    // {
    //     if (myRenderer.material.color == Color.red)
    //     {
    //         Debug.Log("GAME OVER!\nTotal Scores = " + scores);
    //         gameObject.SetActive(false);   
    //     }
    // }
}
