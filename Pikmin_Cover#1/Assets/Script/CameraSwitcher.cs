using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public List<CinemachineVirtualCamera> cameraList;
    public int activeCameraIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            activeCameraIndex ++;
            if (activeCameraIndex >= cameraList.Count)
            {
                activeCameraIndex = 0;
            }

            for (int i=0; i<cameraList.Count; i++)
            {
                int newpriority = 0;
                if (i ==activeCameraIndex)
                {
                    newpriority = 100;
                }
                cameraList[i].Priority= newpriority;
            }
        }
    }
}
