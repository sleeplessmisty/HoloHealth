using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Won't need scored since we destroy cubes on impact after scoring
    private bool scored = false; // Flag to track if points have been awarded
    private int points = 10; // Points to be awarded on collision with the score area

    void OnCollisionEnter(Collision collision)
    {
        if (!scored)
        {
            if (collision.gameObject.CompareTag("BlueScoreArea") && gameObject.CompareTag("BlueCube"))
            {
                AwardPoints();
                Destroy(gameObject);
            }
            else if (collision.gameObject.CompareTag("RedScoreArea") && gameObject.CompareTag("RedCube"))
            {
                AwardPoints();
                Destroy(gameObject);
            }
        }
    }

    void AwardPoints()
    {
        GameManager.instance.AddScore(points);
        scored = true;
    }
}
    