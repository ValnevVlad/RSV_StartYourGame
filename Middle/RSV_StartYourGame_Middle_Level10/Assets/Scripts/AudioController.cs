using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource bomb;
    [SerializeField] AudioSource diamond1;
    [SerializeField] AudioSource diamond2;

    public void BombExplosion()
    {
        bomb.Play();
    }

    public void GetDiamond1Audio()
    {
        diamond1.Play();
    }

    public void GetDiamond2Audio()
    {
        diamond2.Play();
    }
}
