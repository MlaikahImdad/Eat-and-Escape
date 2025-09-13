using UnityEngine;

public class Player : MonoBehaviour
{
    float moveSpeed = 5f;
    void Start()
    {
        Instructions();
    }

    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
    void Instructions()
    {
        Debug.Log("Move this square carefully, it shouldn't touch by wall, ball or any other dropping object. ");
        Debug.Log("More beans you'll eat, more scores you'll get");
        Debug.Log("Hit, in state when player is red, will result Player's death.");
    }
}
