using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCameraUpwards : MonoBehaviour
{

	private Vector3 startPosition = new Vector3(5, 3.2f, 5);
	private Vector3 aimedPosition = new Vector3(0, 0.1f, 0);
	//public float speed = 1.0f;

	//public bool placedIngredient = false;

	public GameObject cameraHolder;

    public AudioClip placeClipOne;
    public AudioClip placeClipTwo;
    public AudioClip placeClipThree;
    public AudioClip placeClipFour;

    public AudioSource placeSourceOne;
    public AudioSource placeSourceTwo;
    public AudioSource placeSourceThree;
    public AudioSource placeSourceFour;

    public AudioSource[] splats = new AudioSource[3];

    public int i = 0;


    // Start is called before the first frame update
    void Start()
	{
		cameraHolder = GameObject.Find("CameraForSandwich");

        placeSourceOne.clip = placeClipOne;
        placeSourceTwo.clip = placeClipTwo;
        placeSourceThree.clip = placeClipThree;
        placeSourceFour.clip = placeClipFour;

        splats[0] = placeSourceOne;
        splats[1] = placeSourceTwo;
        splats[2] = placeSourceThree;
        splats[3] = placeSourceFour;

    }




	void Update()
	{

		if (Input.GetButtonDown("Fire1"))
		{

			startPosition = startPosition + aimedPosition;

			cameraHolder.transform.position = startPosition;

            var random = new Random();

            i = Random.Range(0, splats.Length);
            Debug.Log(i);
			//cameraHolder.transform.Translate(0, 0.1f * Time.deltaTime, 0);

			//placedIngredient = false;

		}
	
	}






}
