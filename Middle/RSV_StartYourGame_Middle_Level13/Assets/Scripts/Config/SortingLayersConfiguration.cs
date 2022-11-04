using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "SortingLayersConfig", menuName = "Config/SortingLayersConfig", order = 0)]
    public class SortingLayersConfiguration : ScriptableObject
    {
        [SerializeField] public int tileLayerId;
        [SerializeField] public int selectedTileLayerId;
    }
}