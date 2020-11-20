/*
References

https://www.youtube.com/watch?v=Q4rtR8iNFbY


*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{

    //variables used for generating the ongoing track
    public Transform tile1Obj;
    private Vector3 nextTileSpawn;

    //variables for the obstacles
    public Transform blueWallObj;
    private Vector3 nextBlueWallSpawn;
    private int randomX;
    

    // Start is called before the first frame update
    void Start()
    {
        nextTileSpawn.z = 18;
        StartCoroutine(spawnTile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTile(){
        yield return new WaitForSeconds(1);
        randomX = Random.Range(-2, 3);
        nextBlueWallSpawn = nextTileSpawn;
        nextBlueWallSpawn.y = .18f;
        nextBlueWallSpawn.x = randomX;  
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(blueWallObj, nextBlueWallSpawn, blueWallObj.rotation);
        nextTileSpawn.z += 3;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());
    }

}
