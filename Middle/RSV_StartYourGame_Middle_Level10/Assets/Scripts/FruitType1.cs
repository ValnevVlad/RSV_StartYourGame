using UnityEngine;
using UnityEngine.EventSystems;

public class FruitType1 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Player _player;
    [SerializeField] private AudioController _audio;
    [SerializeField] private float falling_speed = 0.1f;

    private int points_value = 10;

    public void OnPointerClick(PointerEventData eventData)
    {
        _audio.GetDiamond1Audio();
        Destroy(gameObject);
        //Debug.Log("Type1");
        _player.UpdatePoints(points_value);
    }

    private void Update()
    {
        transform.Translate(Vector3.down * falling_speed);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        //Debug.Log("Trigger Fruit1");
        _player.Hit();
        Destroy(this.gameObject);
    }

}
