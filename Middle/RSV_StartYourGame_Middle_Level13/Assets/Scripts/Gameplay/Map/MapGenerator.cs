using UnityEngine;

namespace Gameplay.Map
{
    public class MapGenerator : MonoBehaviour
    {
        [SerializeField] private MapCoordinates coordinates;
        [SerializeField] private TileMap map;

        private void Awake()
        {
            Generate();
        }

        private void Generate()
        {
            map.ClearTiles();
            for (int x = 0; x < map.MapSize.x; x++)
            {
                for (int y = 0; y < map.MapSize.y; y++)
                {
                    map.SpawnRandomTile(new Vector2Int(x, y));
                }
            } 
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            if (!coordinates) return;
            var demoMapSize = map.MapSize - Vector2Int.one;
            var startPoint = coordinates.GetPointPos(Vector2Int.zero);
            var upPoint = coordinates.GetPointPos(Vector2Int.up * demoMapSize.y);
            var rightPoint = coordinates.GetPointPos(Vector2Int.right*demoMapSize.x);
            var maxPoint = coordinates.GetPointPos(Vector2Int.up * demoMapSize.y + Vector2Int.right*demoMapSize.x);
            Gizmos.DrawLine(startPoint, upPoint);
            Gizmos.DrawLine(maxPoint, upPoint);
            Gizmos.DrawLine(maxPoint, rightPoint);
            Gizmos.DrawLine(startPoint, rightPoint);
        }
    }
}