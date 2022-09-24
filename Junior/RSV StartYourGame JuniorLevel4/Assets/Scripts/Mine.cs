using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class Mine : DistanceOnClick {

    public static readonly string Name = "Mine";
    protected override void OnClick() {
        Vector2 selfPosition = transform.position;

        //Castle
        Vector2 CastlePosition = GameObject.Find("Castle").transform.position;
        Debug.Log("Distance from " + Name + " to " + Castle.Name + " equals to " + Vector2.Distance(selfPosition, CastlePosition));
        //Archer
        //Vector2 ArcherPosition = GameObject.Find("Archer arena").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Archer_arena.Name + " equals to " + Vector2.Distance(selfPosition, ArcherPosition));
        //Gate
        //Vector2 GatePosition = GameObject.Find("Gate_script").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Gate_script.Name + " equals to " + Vector2.Distance(selfPosition, GatePosition));
        //Stable
        Vector2 StablePosition = GameObject.Find("Stable").transform.position;
        Debug.Log("Distance from " + Name + " to " + Stable.Name + " equals to " + Vector2.Distance(selfPosition, StablePosition));
        //House
        Vector2 HousePosition = GameObject.Find("House").transform.position;
        Debug.Log("Distance from " + Name + " to " + House.Name + " equals to " + Vector2.Distance(selfPosition, HousePosition));
        //Quarry
        //Vector2 QuarryPosition = GameObject.Find("Quarry").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Quarry.Name + " equals to " + Vector2.Distance(selfPosition, QuarryPosition));
    }
}
