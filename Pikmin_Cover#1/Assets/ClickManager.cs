using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClickManager : MonoBehaviour
{
    public Camera camera;
 
    void FixedUpdate()
    {
        Vector2 mousePosition = Input .mousePosition;
        Ray mouseOriginAndDirection = camera.ScreenPointToRay ( mousePosition );

        if (Physics.Raycast(mouseOriginAndDirection, out RaycastHit hitInfo, 100))
        {
            ClickableObject clickableObject  = hitInfo.transform.GetComponent<ClickableObject>();
            if (clickableObject)
            {
                clickableObject.Clicked();

            }
        }
        Debug.DrawRay(mouseOriginAndDirection.origin, mouseOriginAndDirection.direction * 100);
    }
}
