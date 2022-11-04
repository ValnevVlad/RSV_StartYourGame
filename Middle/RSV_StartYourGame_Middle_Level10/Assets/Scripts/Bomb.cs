using UnityEngine;
using UnityEngine.EventSystems;

public class Bomb : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Player _player;
    [SerializeField] private AudioController _audio;
    [SerializeField] private float falling_speed = 0.2f;

    private int points_value = -10;

    public void OnPointerClick(PointerEventData eventData)
    {
        _audio.BombExplosion();
        Destroy(gameObject);
        //Debug.Log("Bomb");
        _player.Hit();
        _player.UpdatePoints(points_value);
    }

    private void Update()
    {
        transform.Translate(Vector3.down * falling_speed);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        //Debug.Log("Trigger Bomb");
        Destroy(this.gameObject);
    }

}
