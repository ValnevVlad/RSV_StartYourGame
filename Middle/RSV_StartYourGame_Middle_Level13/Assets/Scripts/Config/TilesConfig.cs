using System.Collections.Generic;
using Gameplay.Tile;
using UnityEngine;

namespace Gameplay
{
    [CreateAssetMenu(fileName = "AvailableTiles", menuName = "Config/AvailableTiles", order = 0)]
    public class TilesConfig : ScriptableObject
    {
        [SerializeField]
        public List<TileEntity> tilePrefabs;
    }
}