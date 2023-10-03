using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    public ParticleSystem groundMarkPrefab;
    public float markDuration = 5f; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaceGroundMark();
        }
    }

    private void PlaceGroundMark()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        { 
            ParticleSystem newMark = Instantiate(groundMarkPrefab, hit.point, Quaternion.identity);
            Destroy(newMark.gameObject, markDuration);
        }
    }
}
