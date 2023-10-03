using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSelection : MonoBehaviour
{
    private bool isSelected = false;

    private void Update()
    {
        if (isSelected && Input.GetMouseButtonDown(0))
        {
            Debug.Log("sb");
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectCharacter();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            DeselectCharacter();
        }
    }

    private void SelectCharacter()
    {
        isSelected = true;
    }

    private void DeselectCharacter()
    {
        isSelected = false;
    }
}



