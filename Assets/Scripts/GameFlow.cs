/*
References

https://www.youtube.com/watch?v=Q4rtR8iNFbY
https://www.youtube.com/watch?v=WPnX2qWzZvA


*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public Transform longRedWallObj;
    public Vector3 nextlongRedWallSpawn;

    public Transform longBlueWallObj;
    public Vector3 nextlongBlueWallSpawn;

    private int randomObst;

/*
    public Transform movingObsObj;
    private Vector3 nextMovingObsObj;*/

    
    

    // Start is called before the first frame update
    void Start()
    {
        nextTileSpawn.z = 18;
        StartCoroutine(spawnTile());

        
    }

    // Update is called once per frame
    void Update()
    {
        if(nextTileSpawn.z == 258)
        {
            nextTileSpawn.z += 0;
            SceneManager.LoadScene(2);
            Debug.Log("Level2");
        }
    }

    IEnumerator spawnTile(){
        yield return new WaitForSeconds(1);
        randomX = Random.Range(-2.4f, 2.4f);

        nextBlueWallSpawn = nextTileSpawn;
        nextBlueWallSpawn.y = .18f;
        nextBlueWallSpawn.x = randomX;  
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(blueWallObj, nextBlueWallSpawn, blueWallObj.rotation);
    
        
        /*nextTileSpawn.z += 3;
        randomX = Random.Range(-2.4f, 2.4f);
        nextRedWallSpawn.z = nextTileSpawn.z;
        nextRedWallSpawn.x = randomX;
        nextRedWallSpawn.y = .18f;
        nextRedWallSpawn.x = randomX;    
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(redWallObj, nextRedWallSpawn, redWallObj.rotation);*/
       
        if(randomX == 0)
        {
            randomX = 1;
        }
        else if(randomX == 1)
        {
            randomX =- 1;
        }
        else
        {
            randomX = 0;
        }

        randomObst = Random.Range(0,3);
        if(randomObst == 0)
        {
            nextTileSpawn.z += 3;
            nextlongRedWallSpawn.z = nextTileSpawn.z;
            nextlongRedWallSpawn.y = .33f;
            nextlongRedWallSpawn.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(longRedWallObj, nextlongRedWallSpawn, longRedWallObj.rotation);

        }
        
        else if (randomObst == 1)
        {
            nextTileSpawn.z += 3;
            randomX = Random.Range(-2.4f, 2.4f);
            nextRedWallSpawn.z = nextTileSpawn.z;
            nextRedWallSpawn.x = randomX;
            nextRedWallSpawn.y = .18f;
            nextRedWallSpawn.x = randomX;    
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(redWallObj, nextRedWallSpawn, redWallObj.rotation);
        }
        else 
        {  
            nextTileSpawn.z += 3;
            nextlongBlueWallSpawn.z = nextTileSpawn.z;
            nextlongBlueWallSpawn.y = .33f;
            nextlongBlueWallSpawn.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(longBlueWallObj, nextlongBlueWallSpawn, longBlueWallObj.rotation);

        }


        
        
       
       /* nextMovingObsObj.z = nextTileSpawn.z;
        nextMovingObsObj.y = .33f;
        nextMovingObsObj.x = randomX;
        Instantiate(movingObsObj, nextMovingObsObj, movingObsObj.rotation);
    */
        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());
    }

}
