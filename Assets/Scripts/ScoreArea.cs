using UnityEngine;
using UnityEngine.UI;

public class ScoreArea : MonoBehaviour
{
    public int points = 10; // Points awarded when a cube collides with this score area

    public int GetPoints()
    {
        return points;
    }
}
