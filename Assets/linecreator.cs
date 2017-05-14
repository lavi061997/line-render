using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class linecreator : MonoBehaviour {
	public GameObject linePrefab;

	line activeLine;
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown (0)) {
			GameObject lineGO = Instantiate(linePrefab);
			activeLine = lineGO.GetComponent<line>();
		}

		if (Input.GetMouseButtonUp (0)) {
		
			activeLine = null;
		}
		if (activeLine != null) {
		
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			activeLine.UpdateLine(mousePos);
		}

	}
}
