using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameManagerProyect gameManager;
    public bool isLeftGoal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            if (isLeftGoal) gameManager.GoalLeft();
            else gameManager.GoalRight();
        }
    }
}
