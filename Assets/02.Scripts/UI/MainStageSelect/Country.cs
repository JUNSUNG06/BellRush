using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public WorldMap worldMap;
    public Transform countryPos;

    public void SetMapPosHere()
    {
        worldMap.SetPos(countryPos.position);
    }
}
