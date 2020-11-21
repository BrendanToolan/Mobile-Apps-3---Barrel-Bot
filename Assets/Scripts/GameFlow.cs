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
    private float randomX;

    public Transform redWallObj;
    private Vector3 nextRedWallSpawn;
    private float randomX2;
    
    

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
        randomX = Random.Range(-2.4f, 2.4f);
        randomX2 = Random.Range(-2.4f, 2.4f);
        nextBlueWallSpawn = nextTileSpawn;
        nextRedWallSpawn = nextTileSpawn;
        nextBlueWallSpawn.y = .18f;
        nextRedWallSpawn.y = .18f;
        nextBlueWallSpawn.x = randomX;  
        nextRedWallSpawn.x = randomX2;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(blueWallObj, nextBlueWallSpawn, blueWallObj.rotation);
        Instantiate(redWallObj, nextRedWallSpawn, redWallObj.rotation);
        nextTileSpawn.z += 3;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());
    }

}
