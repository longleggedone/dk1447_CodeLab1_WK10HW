using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class AsteroidManager {

    JSONArray asteroidArray;


    public AsteroidManager()
    {
        asteroidArray = new JSONArray();
    }


	public void SaveAsteroid(GameObject asteroid)
    {
        // 1: Create asteroid data for this asteroid.
        AsteroidData ad = new AsteroidData(asteroid.transform.position, asteroid.transform.localScale);

        // 2: Add asteroid data to asteroidArray as JSONClass
        asteroidArray.Add(ad.ToJSON());
    }


    public void WriteArray()
    {
        UtilScript.WriteJSONtoFile(Application.dataPath, "SavedAsteroids.txt", asteroidArray);
    }
}
