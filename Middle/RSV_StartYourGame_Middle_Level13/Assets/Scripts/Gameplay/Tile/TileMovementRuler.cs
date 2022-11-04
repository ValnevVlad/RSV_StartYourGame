using Gameplay.Map;
using UnityEngine;

namespace Gameplay.Tile
{
    public class TileMovementRuler : MonoBehaviour
    {
        [SerializeField] private TileMap map;
        [SerializeField] private GameplayEventChannel eventChannel;
        private TileEntity selectedTileEntity = null;
        private Vector2Int lastSwapFrom;
        private Vector2Int lastSwapTo;
        private bool _swappingLocked = false;

        private void OnEnable()
        {
            eventChannel.OnTileSwapFailedEvent.AddListener(OnSwapFailed);
            eventChannel.OnTilesCollectingFinishedEvent.AddListener(OnCollectingFinished);
        }

        private void OnCollectingFinished()
        {
            _swappingLocked = false;
        }

        private void OnSwapFailed()
        {
            map.SwapTiles(lastSwapFrom, lastSwapTo);
        }

        private void OnDisable()
        {
            eventChannel.OnTileSwapFailedEvent.RemoveListener(OnSwapFailed);
            eventChannel.OnTilesCollectingFinishedEvent.RemoveListener(OnCollectingFinished);
        }

        public bool Select(TileEntity tileEntity)
        {
            if(selectedTileEntity != null) return false;
            if (_swappingLocked) return false;
            selectedTileEntity = tileEntity;
            return true;
        }

        public void Release(TileEntity tileEntity, Vector3 deltaMovement)
        {
            if(selectedTileEntity == null) return;
            selectedTileEntity = null;
            var movementVector = Vector2Int.RoundToInt(deltaMovement);
            if(movementVector.magnitude > 1f) return;
            lastSwapFrom = tileEntity.Pos;
            lastSwapTo = tileEntity.Pos + movementVector;
            if (map.SwapTiles(tileEntity.Pos, tileEntity.Pos + movementVector))
            {
                _swappingLocked = true;
                eventChannel.TilesSwapped(tileEntity);
            }
        }
        
    }
}