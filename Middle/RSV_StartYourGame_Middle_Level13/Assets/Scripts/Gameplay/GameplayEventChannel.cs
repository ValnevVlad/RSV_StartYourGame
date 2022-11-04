using Gameplay.Tile;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Gameplay
{
    [CreateAssetMenu(fileName = "GameplayEventChannel", menuName = "Channels/GameplayEvents", order = 0)]
    public class GameplayEventChannel : ScriptableObject
    {
        public UnityEvent<TileEntity> OnTileSwapEvent = new UnityEvent<TileEntity>();
        public UnityEvent OnResetRequiredEvent = new UnityEvent();
        public UnityEvent OnShuffleRequiredEvent = new UnityEvent();
        public UnityEvent OnTilesCollectingFinishedEvent = new UnityEvent();
        public UnityEvent OnTileSwapFailedEvent = new UnityEvent();
        public void TilesSwapped(TileEntity entity)
        {
            OnTileSwapEvent.Invoke(entity);
        }
        public void TilesSwappedFailed()
        {
            OnTileSwapFailedEvent.Invoke();
        }

        public void TilesCollectingFinished()
        {
            OnTilesCollectingFinishedEvent.Invoke();
        }

        public void RequireReset()
        {
            OnResetRequiredEvent.Invoke();
        }
        public void RequireShuffle()
        {
            OnShuffleRequiredEvent.Invoke();
        }
    }
}