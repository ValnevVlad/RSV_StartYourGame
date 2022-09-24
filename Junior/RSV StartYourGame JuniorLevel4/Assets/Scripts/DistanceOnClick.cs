using UnityEngine;

public abstract class DistanceOnClick : MonoBehaviour {
    private void OnMouseDown() {
        OnClick();
    }

    protected abstract void OnClick();




}
