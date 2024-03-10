using UnityEngine;

namespace MTM101BMDE
{
    public class Obstacle : MonoBehaviour
    {
        public ObstacleType obstacleType;

        private void OnTriggerEnter(Collider other)
        {
            // Check if the obstacle is blocking the player
            if (other.CompareTag("Player"))
            {
                HandleObstacle(other.GetComponent<PlayerManager>());
            }
        }

        private void HandleObstacle(PlayerManager player)
        {
            // Implement obstacle behavior based on obstacle type
            switch (obstacleType)
            {
                case ObstacleType.Pit:
                    // Do something when the player encounters a pit
                    Debug.Log("You've encountered a pit!");
                    break;
                // Add more cases for other obstacle types
                default:
                    break;
            }
        }
    }
}