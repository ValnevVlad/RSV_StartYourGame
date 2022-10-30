using UnityEngine;

public class KeyController : MonoBehaviour
{
    public float rotation_speed = 0.03f;
    void Update()
    {
        transform.Rotate(0, rotation_speed, 0);

    } 

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.PickUpKey();
                Debug.Log("Has Key!");
            Destroy(gameObject);
        }
    }
}
