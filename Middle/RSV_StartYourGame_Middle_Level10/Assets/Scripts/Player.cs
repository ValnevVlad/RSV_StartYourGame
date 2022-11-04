using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameController _game;

    public int playerPoints { get; private set; } = 0;
    public int playerHealth { get; private set; } = 5;
    public bool isAlive { get; private set; } = true;

    private void Start()
    {
        playerPoints = 0;
        playerHealth = 5;
    }

    public void  Hit()
    {
        playerHealth -= 1;

        if (playerHealth <= 0)
        {
            isAlive = false;
        }
        //Debug.Log(playerHealth);
        _game.UpdatePlayerHealth();
    }

    public void UpdatePoints(int points)
    {
        var temp_point = playerPoints + points;
        if (temp_point < 0)
        {
            return;
        }
        playerPoints = playerPoints + points;
        //Debug.Log(playerPoints);
    }
}
