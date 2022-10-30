using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Player : MonoBehaviour
{
    private Movement _movement;

    public bool isAlive { get; private set; } = true;
    public bool hasKey { get; private set; } = false;

    private void Awake()
    {
        _movement = GetComponent<Movement>();
    }

    public void Enable()
    {
        _movement.enabled = true;
    }

    public void Disable()
    {
        _movement.enabled = false;
    }

    public void Kill()
    {
        isAlive = false;
    }

    public void PickUpKey()
    {
        hasKey = true;
    }
}
