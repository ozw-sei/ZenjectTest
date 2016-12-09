using UnityEngine;
using System.Collections;
using Zenject;

public class HogeController : MonoBehaviour {

	[Inject]
	IHogeService hogeService;

	[Inject]
	IPrefab prefab;

	// Use this for initialization
	void Start () {
		hogeService.Hello ();

		Debug.Log(prefab.ToString ());
	}


}
