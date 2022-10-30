using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStone_Controller : MonoBehaviour
{
    [SerializeField] private GameObject falling_rock_pref;
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private GameObject[] hills;

    void Update()
    {
        // Определяем расстояние до холмов
        List<float> hills_dist = new List<float>();
        foreach (GameObject hill in hills)
        {
            float dist = Vector3.Distance(hill.transform.position, playerCamera.transform.position);
            hills_dist.Add(dist);

        }

        // Выбираем наименьшее расстояние
        float smallestDistance = hills_dist[0];
        int index = 0;
        for (int i = 1; i < hills_dist.Count; i++)
        {
            if (hills_dist[i] < smallestDistance)
            {
                smallestDistance = hills_dist[i];

                index = i;
            }
        }

        // Если нажата клавиша Х - спавним камень по центру холма.
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Pressed 'X' btn, Min distance to hill: " + hills[index].name);
            Instantiate(falling_rock_pref, new Vector3(hills[index].transform.position.x + 15f, hills[index].transform.position.y + 40f,
                hills[index].transform.position.z), hills[index].transform.rotation);
        }
    }
}
