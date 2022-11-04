using System.Collections.Generic;
using System.Linq;
using Gameplay.Tile;
using UnityEngine;

namespace Gameplay.Map
{
    public class TileMap : MonoBehaviour
    {
        [SerializeField] private MapCoordinates coordinates;
        [SerializeField] private TileMovementRuler movementRuler;
        [SerializeField] private TilesConfig tilesConfig;
        [SerializeField] private List<TileEntity> tiles;
        [SerializeField] private Transform containerTransform;
        [SerializeField] private Vector2Int mapSize;
        private Dictionary<Vector2Int, TileEntity> tileMap = new Dictionary<Vector2Int, TileEntity>();

        public TileMovementRuler MovementRuler => movementRuler;

        public Vector2Int MapSize => mapSize;
        public Dictionary<Vector2Int, TileEntity> Map => tileMap;
        public MapCoordinates Coordinates => coordinates;
        public int[,] GetTileMap()
        {
            var width = tiles.Max(tile => tile.Pos.x)+1;
            var height = tiles.Max(tile => tile.Pos.y)+1;
            var result = new int[width, height];
            tiles.ForEach(tile => result[tile.Pos.x, tile.Pos.y] = tile.TileTypeId);
            return result;
        }

        public TileEntity GetTileAt(Vector2Int pos)
        {
            if (!tileMap.TryGetValue(pos, out var tile)) return null;
            return tile;
        }

        public void ClearTiles()
        {
            tileMap.Clear();
            foreach (var tile in tiles)
            {
                Destroy(tile.gameObject);
            }
            tiles.Clear();
        }

        public TileEntity SpawnRandomTile(Vector2Int pos)
        {
            var randomPref = tilesConfig.tilePrefabs[Random.Range(0, tilesConfig.tilePrefabs.Count)];
            return SpawnTile(randomPref, pos);
        }
        public TileEntity SpawnTile(TileEntity prefab, Vector2Int pos)
        {
            var tile = Instantiate(prefab, coordinates.GetPointPos(pos), Quaternion.identity,
                containerTransform);
            tiles.Add(tile);
            tileMap[pos] = tile;
            tile.Setup(pos, this);
            return tile;
        }

        public bool SwapTilesDirectly(Vector2Int from, Vector2Int to)
        {
            if(!tileMap.ContainsKey(from) || !tileMap.ContainsKey(to))return false;
            var tileA = tileMap[from];
            var tileB = tileMap[to];
            
            SetTilePosition(tileA, to);
            SetTilePosition(tileB, from);
            return true;
        }
        
        public void DestroyTile(Vector2Int pos)
        {
            if (!tileMap.ContainsKey(pos)) return;
            var tile = tileMap[pos];
            tiles.Remove(tile);
            tileMap.Remove(pos);
            Destroy(tile.gameObject);
        }
        public bool SwapTiles(Vector2Int from, Vector2Int to)
        {
            if ((from - to).sqrMagnitude != 1) return false;
            return SwapTilesDirectly(from, to);
        }

        private void SetTilePosition(TileEntity tileEntity, Vector2Int pos)
        {
            tileMap[pos] = tileEntity;
            tileEntity.SetPosition(pos);
        }
    }
}