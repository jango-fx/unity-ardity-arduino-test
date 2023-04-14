using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject baseCube;
    public int yOffset = 0;
    [Range(1,60)]
    public int numCubes = 10;
    public List<GameObject> cubes = new List<GameObject>();

    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    [ContextMenu("New Level")]
    void Init()
    {   
        foreach (GameObject c in cubes)
        {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.delayCall += () =>
        {
            DestroyImmediate(c);
        }; 
        #else
            Destroy(c);  
        #endif      
        }
        cubes = new List<GameObject>();

        for(int i = 0; i < numCubes; i++)
        {
            int lane = Random.Range(-1, 2);
            GameObject newCube = Instantiate(baseCube, new Vector3(lane, yOffset, 0), Quaternion.identity, this.transform); 
            newCube.SetActive(true);
            cubes.Add(newCube);
            this.transform.Rotate(360/numCubes, 0.0f, 0.0f, Space.Self);
        }
    }

    void OnValidate(){
        Init();
    }
    
}
