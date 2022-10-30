using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] private Material _closeMaterial;
    [SerializeField] private Material _openMaterial;

    private bool isOpen;

    private MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    public void Open()
    {
        isOpen = true;
        _renderer.sharedMaterial = _openMaterial;
    }

    public void Close()
    {
        isOpen = false;
        _renderer.sharedMaterial = _closeMaterial;
    }
}
