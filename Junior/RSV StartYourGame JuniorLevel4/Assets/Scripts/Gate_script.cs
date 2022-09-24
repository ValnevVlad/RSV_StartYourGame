using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class Gate_script : DistanceOnClick {
   
    public static readonly string Name = "Gate";
    protected override void OnClick() {
        Vector2 selfPosition = transform.position;

        //Castle
        //Vector2 CastlePosition = GameObject.Find("Castle").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Castle.Name + " equals to " + Vector2.Distance(selfPosition, CastlePosition));
        //Archer
        Vector2 ArcherPosition = GameObject.Find("Archer arena").transform.position;
        Debug.Log("Distance from " + Name + " to " + Archer_arena.Name + " equals to " + Vector2.Distance(selfPosition, ArcherPosition));
        //Stable
        //Vector2 StablePosition = GameObject.Find("Stable").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Stable.Name + " equals to " + Vector2.Distance(selfPosition, StablePosition));
        //House
        //Vector2 HousePosition = GameObject.Find("House").transform.position;
        //Debug.Log("Distance from " + Name + " to " + House.Name + " equals to " + Vector2.Distance(selfPosition, HousePosition));
        //Quarry
        Vector2 QuarryPosition = GameObject.Find("Quarry").transform.position;
        Debug.Log("Distance from " + Name + " to " + Quarry.Name + " equals to " + Vector2.Distance(selfPosition, QuarryPosition));
        //Mine
        //Vector2 MinePosition = GameObject.Find("Mine").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Mine.Name + " equals to " + Vector2.Distance(selfPosition, MinePosition));

    }
}
