using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObjects : MonoBehaviour
{		
		public Vector3 rotate;
		public Vector3 direction;

		void Update()	
		{
			transform.Translate(direction * Time.deltaTime);
			this.transform.rotation *= Quaternion.Euler(rotate);
		}
}
