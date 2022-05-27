using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARObjectPlacement : MonoBehaviour
{

    public ARSessionOrigin aRSession;
    public GameObject cube;

    private RaycastManager raycastManager;

    private List<RaycastHit> raycastHits = new List<RaycastHit>();
    private bool collision;

    // Start is called before the first frame update
    void Start()
    {
        raycastManager = aRSession.GetComponent<RaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            collision = raycastManager.Raycast(Input.MousePosition, raycastHits, TrackableType.PlaneWithinPolygon);

            if(collision)
            {

            }
        }
    }
}
