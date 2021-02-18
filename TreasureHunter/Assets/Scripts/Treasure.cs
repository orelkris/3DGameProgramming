using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    GameObject treasure;

    // random list of colours
    Color32[] colorList = { Color.red, Color.blue, Color.green, Color.magenta };
    // Start is called before the first frame update
    void Start()
    {
        // Find the terrain object
        GameObject terrain = GameObject.Find("Terrain");
        
        // Get the size of the terrain object
        Vector3 size = terrain.GetComponent<Terrain>().terrainData.size;
        
        // create a sphere object
        treasure = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        // place the sphere at a random position within the bounds of the terrain
        treasure.transform.position = new Vector3(Random.Range(50, size.x - 50), 0, Random.Range(50, size.z - 50));

        // create a new vector
        Vector3 newPos = treasure.transform.position;

        // transform the y position of this vector to match the height of the terrain based on random x and y position
        // of the generated sphere
        newPos.y = Terrain.activeTerrain.SampleHeight(treasure.transform.position) + 5;

        // place the treasure at the surface of the terrain so it is visible
        treasure.transform.position = newPos;

        // make the size of the sphere larger
        treasure.transform.localScale += new Vector3(10, 10, 10);

        // place the empty object where the new sphere is so that the player can collide with the treasure object to win
        this.transform.position = treasure.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // create a random float
        float change = 100f % Random.Range(0, 100);

        // rotate the treasure sphere at random to make it look cool
        treasure.transform.Rotate(new Vector3(Random.Range(1, 5), Random.Range(2, 10), Random.Range(10, 20)) * Time.deltaTime * 10f);

        // if the random float is above 40, change the colour of the sphere based on the list of colours
        if (change > 40)
        {
            treasure.GetComponent<Renderer>().material.color = colorList[Random.Range(0, 3)];
        }
    }
}
