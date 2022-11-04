using Gameplay.Map;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay.Tile
{
    public class TileEntity : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer renderer;
        [SerializeField] private int tileTypeId;

        public UnityEvent OnWasCollectedEvent = new UnityEvent();
        public UnityEvent OnPositionWasChangedEvent = new UnityEvent();

        public Vector2Int Pos { get; private set; }
        public TileMap Map { get; private set; }

        private bool _collected;
        
        public int TileTypeId => tileTypeId;
        
        public Vector3 TargetTilePosition => Map.Coordinates.GetPointPos(Pos);
        public SpriteRenderer Renderer => renderer;

        public void Setup(Vector2Int pos, TileMap map)
        {
            Map = map;
            Pos = pos;
        }

        public void SetPosition(Vector2Int newPos)
        {
            Pos = newPos;
            OnPositionWasChangedEvent.Invoke();
        }

        public void SetCollected()
        {
            if (_collected) return;
            _collected = true;
            OnWasCollectedEvent.Invoke();
        }
        
    }
}