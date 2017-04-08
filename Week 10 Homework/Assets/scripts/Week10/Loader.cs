using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

	void Start () {

        AsteroidManager am = new AsteroidManager();

        AsteroidData[] asteroidDatas = am.ReadAsteroids();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
