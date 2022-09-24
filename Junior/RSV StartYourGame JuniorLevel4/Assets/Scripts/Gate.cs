using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class Gate : DistanceOnClick {
    public static readonly string Name = "Gate";

    protected override void OnClick() {
        Vector2 selfPosition = transform.position;
        //Напиши код для поиска расстояния до всех объектов и вывода их в дэбаг лог

        //Quarry
        Vector2 QuarryPosition = GameObject.Find("Quarry").transform.position;
        Debug.Log("Distance from " + Name + " to " + Quarry.Name + " equals to " + Vector2.Distance(selfPosition, QuarryPosition));

        //Mill
        Vector2 MillPosition = GameObject.Find("Mill").transform.position;
        Debug.Log("Distance from " + Name + " to " + Mill.Name + " equals to " + Vector2.Distance(selfPosition, MillPosition));

        ////ArcherArena
        //Vector2 ArcherPosition = GameObject.Find("ArcherArena").transform.position;
        //Debug.Log("Distance from " + Name + " to " + ArcherArena.Name + " equals to " + Vector2.Distance(selfPosition, ArcherPosition));

        ////Castle
        //Vector2 CastlePosition = GameObject.Find("Castle").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Castle.Name + " equals to " + Vector2.Distance(selfPosition, CastlePosition));

        ////Hat
        //Vector2 HatPosition = GameObject.Find("Hat").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Hat.Name + " equals to " + Vector2.Distance(selfPosition, HatPosition));

        ////SawMill
        //Vector2 SawmillPosition = GameObject.Find("Sawmill").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Sawmill.Name + " equals to " + Vector2.Distance(selfPosition, SawmillPosition));
        

    }
}
