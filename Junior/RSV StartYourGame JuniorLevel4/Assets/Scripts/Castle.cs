using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class Castle : DistanceOnClick {
    public static readonly string Name = "Castle";

    protected override void OnClick() {
        Vector2 selfPosition = transform.position;
        //Напиши код для поиска расстояния до всех объектов и вывода их в дэбаг лог

        ////Gate
        //Vector2 GatePosition = GameObject.Find("Gate").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Gate.Name + " equals to " + Vector2.Distance(selfPosition, GatePosition));

        //SawMill
        Vector2 SawmillPosition = GameObject.Find("Sawmill").transform.position;
        Debug.Log("Distance from " + Name + " to " + Sawmill.Name + " equals to " + Vector2.Distance(selfPosition, SawmillPosition));

        //Mill
        Vector2 MillPosition = GameObject.Find("Mill").transform.position;
        Debug.Log("Distance from " + Name + " to " + Mill.Name + " equals to " + Vector2.Distance(selfPosition, MillPosition));

        //ArcherArena
        Vector2 ArcherPosition = GameObject.Find("ArcherArena").transform.position;
        Debug.Log("Distance from " + Name + " to " + ArcherArena.Name + " equals to " + Vector2.Distance(selfPosition, ArcherPosition));

        //Hat
        Vector2 HatPosition = GameObject.Find("Hat").transform.position;
        Debug.Log("Distance from " + Name + " to " + Hat.Name + " equals to " + Vector2.Distance(selfPosition, HatPosition));

        //Quarry
        Vector2 QuarryPosition = GameObject.Find("Quarry").transform.position;
        Debug.Log("Distance from " + Name + " to " + Quarry.Name + " equals to " + Vector2.Distance(selfPosition, QuarryPosition));
    }
}
