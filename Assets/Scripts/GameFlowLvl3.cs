﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlowLvl3 : MonoBehaviour
{
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

    public Transform wallWithGap;
    public Vector3 nextWallWithGap1;

    public Transform wallWithGap2;
    public Vector3 nextWallWithGap2;

    public Transform wallWithGap3;
    public Vector3 nextWallWithGap3;

    public Transform obstObj8;
    public Vector3 nextObst8;

    public Transform obstObj9;
    public Vector3 nextObst9;

    public Transform obstObj10;
    public Vector3 nextObst10;

    

    private int randomObst;

/*
    public Transform movingObsObj;
    private Vector3 nextMovingObsObj;*/

    
    

    // Start is called before the first frame update
    void Start()
    {
        nextTileSpawn.z = 28;
        StartCoroutine(spawnTile());
    }

    // Update is called once per frame
    void Update()
    {
        if(nextTileSpawn.z == 321)
        {
            nextTileSpawn.z += 0;
            SceneManager.LoadScene(525);
            Debug.Log("GameDone");
        }
        
    }

    IEnumerator spawnTile(){
        yield return new WaitForSeconds(0.5f);
        randomX = Random.Range(-2.4f, 2.4f);

        nextBlueWallSpawn = nextTileSpawn;
        nextBlueWallSpawn.y = .55f;
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

        randomObst = Random.Range(0,10);
        if(randomObst == 0)
        {
            nextTileSpawn.z += 5;
            nextlongRedWallSpawn.z = nextTileSpawn.z;
            nextlongRedWallSpawn.y = .40f;
            nextlongRedWallSpawn.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(longRedWallObj, nextlongRedWallSpawn, longRedWallObj.rotation);

        }
        
        else if (randomObst == 1)
        {
            nextTileSpawn.z += 5;
            randomX = Random.Range(-2.4f, 2.4f);
            nextRedWallSpawn.z = nextTileSpawn.z;
            nextRedWallSpawn.x = randomX;
            nextRedWallSpawn.y = .55f;
            nextRedWallSpawn.x = randomX;    
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(redWallObj, nextRedWallSpawn, redWallObj.rotation);
        }
        else if (randomObst == 2)
        {  
            nextTileSpawn.z += 5;
            nextWallWithGap1.z = nextTileSpawn.z;
            nextWallWithGap1.y = .33f;
            nextWallWithGap1.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(wallWithGap, nextWallWithGap1, wallWithGap.rotation);

        }
        else if (randomObst == 3)
        {  
            nextTileSpawn.z += 5;
            nextWallWithGap2.z = nextTileSpawn.z;
            nextWallWithGap2.y = .33f;
            nextWallWithGap2.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(wallWithGap2, nextWallWithGap2, wallWithGap2.rotation);

        }
        else if (randomObst == 4)
        {  
            nextTileSpawn.z += 5;
            nextWallWithGap3.z = nextTileSpawn.z;
            nextWallWithGap3.y = .33f;
            nextWallWithGap3.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(wallWithGap3, nextWallWithGap3, wallWithGap3.rotation);

        }
        else if (randomObst == 5)
        {  
            nextTileSpawn.z += 5;
            nextlongBlueWallSpawn.z = nextTileSpawn.z;
            nextlongBlueWallSpawn.y = .40f;
            nextlongBlueWallSpawn.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(longBlueWallObj, nextlongBlueWallSpawn, longBlueWallObj.rotation);

        }
        else if (randomObst == 6)
        {  
            nextTileSpawn.z += 5;
            nextObst8.z = nextTileSpawn.z;
            nextObst8.y = .40f;
            nextObst8.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(obstObj8, nextObst8, obstObj8.rotation);

        }
        else if (randomObst == 7)
        {  
            nextTileSpawn.z += 5;
            nextObst9.z = nextTileSpawn.z;
            nextObst9.y = .40f;
            nextObst9.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(obstObj9, nextObst9, obstObj9.rotation);

        }
        else if (randomObst == 8)
        {  
            nextTileSpawn.z += 5;
            nextObst10.z = nextTileSpawn.z;
            nextObst10.y = .40f;
            nextObst10.x =randomX;
            Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
            Instantiate(obstObj10, nextObst10, obstObj10.rotation);

        }

        
       
       /* nextMovingObsObj.z = nextTileSpawn.z;
        nextMovingObsObj.y = .33f;
        nextMovingObsObj.x = randomX;
        Instantiate(movingObsObj, nextMovingObsObj, movingObsObj.rotation);
    */
        nextTileSpawn.z += 5;
        StartCoroutine(spawnTile());
    }
}