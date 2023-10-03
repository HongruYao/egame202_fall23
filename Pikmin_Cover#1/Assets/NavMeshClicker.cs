using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshClicker : MonoBehaviour
{
    public Camera gameCamera;
    public List<NavMeshAgent> agents = new List<NavMeshAgent>();
    private NavMeshAgent selectedAgent;

    // Start is called before the first frame update
    void Start()
    {
        selectedAgent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Ray mouseRay = gameCamera.ScreenPointToRay(mousePosition);

            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo, Mathf.Infinity))
            {
                NavMeshAgent clickedAgent = hitInfo.collider.GetComponent<NavMeshAgent>();

                if (clickedAgent != null)
                {
                    SelectCharacter(clickedAgent);
                }
                else
                {
                    if (selectedAgent != null)
                    {
                        selectedAgent.SetDestination(hitInfo.point);
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            DeselectCharacter();
        }
    }

    private void SelectCharacter(NavMeshAgent agentToSelect)
    {
        DeselectCharacter();
        selectedAgent = agentToSelect;
    }

    private void DeselectCharacter()
    {
        if (selectedAgent != null)
        {
            selectedAgent = null;
        }
    }
}