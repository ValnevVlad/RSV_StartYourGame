using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player _player;

    [SerializeField] private GameObject[] gameObjects;
    [SerializeField] private GameObject gameParent;
    [SerializeField] private GameObject endGameWindow;
    [SerializeField] private GameObject healthParent;
    [SerializeField] private Texture brokenHeartTex;

    [SerializeField] private Text playerEarnPoints;
    [SerializeField] private Text playerPoints;


    [SerializeField] private float spawnSpeed = 0.5f; // скорость спавна объектов


    private bool gameIsEnd = false;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    // Spawn a Gameobject every spawnSpeed seconds
    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(spawnSpeed);
        }
        
    }

    private void Spawn()
    {
        if (gameIsEnd)
        {
            return;
        }

        // рандомно выбираем объект для спавна
        var go_index = Random.Range(0, gameObjects.Length);
        Vector2 gameobject_position = new Vector2(Random.Range(0, Screen.width), Random.Range(Screen.height - 100, Screen.height));
        Quaternion gameobjectt_rotation = new Quaternion(0, 0, 0, 0);
        Instantiate(gameObjects[go_index],  gameobject_position, gameobjectt_rotation, gameParent.transform);
    }   

    private void Lose()
    {
        gameIsEnd = true;
        StopCoroutine(SpawnObjects());
        gameParent.SetActive(false);
        endGameWindow.SetActive(true);

        playerEarnPoints.text = playerPoints.text;
    }

    private void Update()
    {
        LookAtPlayerHealth();
        playerPoints.text = $"{_player.playerPoints}";
    }

    private void LookAtPlayerHealth()
    {
        if (_player.isAlive == false)
        {
            Lose();
        }
    }

    public void UpdatePlayerHealth()
    {
        if (gameIsEnd)
        {
            return;
        }
        var health_length = healthParent.transform.childCount - 1;
        var healthImage = healthParent.transform.GetChild(health_length - _player.playerHealth).GetComponent<RawImage>();
        healthImage.texture = brokenHeartTex;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
