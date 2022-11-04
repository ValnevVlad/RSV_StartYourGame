using UnityEngine;
using UnityEngine.EventSystems;

public class FruitType2 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Player _player;
    [SerializeField] private AudioController _audio;
    [SerializeField] private float falling_speed = 0.2f;

    private int points_value = 20;

    public void OnPointerClick(PointerEventData eventData)
    {
        _audio.GetDiamond2Audio();
        Destroy(gameObject);
        //Debug.Log("Type2");
        _player.UpdatePoints(points_value);
    }

    private void Update()
    {
        transform.Translate(Vector3.down * falling_speed);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        //Debug.Log("Trigger Fruit2");
        _player.Hit();
        Destroy(this.gameObject);
    }

}
