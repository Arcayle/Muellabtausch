using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor_spawn : MonoBehaviour
{
    public GameObject vfx;
    public Transform startP;
    public Transform endP;
    void Start()
    {
        var startPos = startP.position;
        GameObject obj_vfx = Instantiate(vfx, startPos, Quaternion.identity) as GameObject;

        var endPos = endP.position;

        RotateTo(obj_vfx, endPos);

    }

    void RotateTo (GameObject obj, Vector3 destination)
    {
        var direction = destination - obj.transform.position;
        var rotation = Quaternion.LookRotation(direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
