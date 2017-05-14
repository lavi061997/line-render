using UnityEngine;
using System.Linq;
using System.Collections.Generic;
public class line : MonoBehaviour {

	public LineRenderer linerenderer;
	public EdgeCollider2D edgecol;

	List<Vector2> points;

	public void UpdateLine(Vector2 point){
		if (points == null) {
		
			points = new List<Vector2> ();
			Setpoints (point);
			return;
		}


		if (Vector2.Distance(points.Last(),point) > .1f){
		
			Setpoints(point);
		}
	}

		void Setpoints(Vector2 point){
		points.Add (point);
		linerenderer.SetPosition (points.Count - 1,point);

		if (points.Count > 1) {
			edgecol.points = points.ToArray ();
		}

		}
}

