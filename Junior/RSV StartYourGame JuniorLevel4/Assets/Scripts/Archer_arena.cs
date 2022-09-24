using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class Archer_arena : DistanceOnClick {
    
    public static readonly string Name = "Archer Arena";
    protected override void OnClick() {
        Vector2 selfPosition = transform.position;
        //Пример поиска расстояния от арены лучников до ворот 
        Vector2 GatePosition = GameObject.Find("Gate_script").transform.position;
        Debug.Log("Distance from " + Name + " to " + Gate_script.Name + " equals to " + Vector2.Distance(selfPosition, GatePosition));
        //Напиши код для поиска расстояния до всех объектов и вывода их в дэбаг лог
        //Castle
        Vector2 CastlePosition = GameObject.Find("Castle").transform.position;
        Debug.Log("Distance from " + Name + " to " + Castle.Name + " equals to " + Vector2.Distance(selfPosition, CastlePosition));
        //Stable
        //Vector2 StablePosition = GameObject.Find("Stable").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Stable.Name + " equals to " + Vector2.Distance(selfPosition, StablePosition));
        //House
        Vector2 HousePosition = GameObject.Find("House").transform.position;
        Debug.Log("Distance from " + Name + " to " + House.Name + " equals to " + Vector2.Distance(selfPosition, HousePosition));
        //Quarry
        Vector2 QuarryPosition = GameObject.Find("Quarry").transform.position;
        Debug.Log("Distance from " + Name + " to " + Quarry.Name + " equals to " + Vector2.Distance(selfPosition, QuarryPosition));
        //Mine
        //Vector2 MinePosition = GameObject.Find("Mine").transform.position;
        //Debug.Log("Distance from " + Name + " to " + Mine.Name + " equals to " + Vector2.Distance(selfPosition, MinePosition));
    }
}
