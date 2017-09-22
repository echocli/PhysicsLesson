using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naf : MonoBehaviour {

	public GameObject Laying; 
	public GameObject Treading;
	public GameObject Floating; 
	public GameObject Swimming;

	public GameObject C1; 
	public GameObject C2;
	public GameObject C3; 
	public GameObject C4;

	public Rigidbody L_rb;
	public Rigidbody T_rb;
	public Rigidbody F_rb;
	public Rigidbody S_rb;

	public Rigidbody C1_rb;
	public Rigidbody C2_rb;
	public Rigidbody C3_rb;
	public Rigidbody C4_rb;

    public GameObject Player;
    public Rigidbody rP;

    public GameObject Plane;

    public Material field;
    public Material space;
    public Material stars;

    public GameObject Sphere;

    public GameObject Rain;

    public GameObject Tree;

    public GameObject Canvas;

    public Material history;

    public Material grav;

    // Use this for initialization
    void Start(){
		print(Time.time);

        Player = GameObject.FindGameObjectWithTag("Player");
        rP = Player.GetComponent<Rigidbody>();

		Laying = GameObject.FindGameObjectWithTag("Laying");
		Treading = GameObject.FindGameObjectWithTag("Treading");
		Floating = GameObject.FindGameObjectWithTag ("Floating");
		Swimming = GameObject.FindGameObjectWithTag ("Swimming");

		C1 = GameObject.FindGameObjectWithTag ("CAR");
		C2 = GameObject.FindGameObjectWithTag ("CAR");
		C3 = GameObject.FindGameObjectWithTag ("CAR3");
		C4 = GameObject.FindGameObjectWithTag ("CAR4");

		C1_rb = C1.GetComponent<Rigidbody> ();
		C2_rb = C1.GetComponent<Rigidbody> ();
		C3_rb = C1.GetComponent<Rigidbody> ();
		C4_rb = C1.GetComponent<Rigidbody> ();

		C1.SetActive (false);
		C2.SetActive (false);
		C3.SetActive (false);
		C4.SetActive (false);

		C1_rb.useGravity = false;
		C2_rb.useGravity = false;
		C3_rb.useGravity =false;
		C4_rb.useGravity =false;

		L_rb = Laying.GetComponent<Rigidbody> ();
		T_rb = Treading.GetComponent<Rigidbody> ();
		F_rb = Floating.GetComponent<Rigidbody> ();
		S_rb = Swimming.GetComponent<Rigidbody> ();

		Laying.SetActive (false);
		Treading.SetActive (false);
		Floating.SetActive (false);
		Swimming.SetActive (false);

		T_rb.useGravity = false;
		F_rb.useGravity = false;
		S_rb.useGravity = false;
		L_rb.useGravity = false;

        rP.useGravity = false;
        rP.isKinematic = false;
        Plane = GameObject.FindGameObjectWithTag("Plane");
        Plane.SetActive(false);

        Sphere = GameObject.FindGameObjectWithTag("Sphere");

        Rain = GameObject.FindGameObjectWithTag("Rain");

        Tree = GameObject.FindGameObjectWithTag("Tree");
        Tree.SetActive(false);

        //head.SetActive(false);

        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        Canvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		print(Time.time);
        //print("delta" + Time.fixedDeltaTime);
		if (Time.fixedTime >= 21) {
			Laying.SetActive (true);
			Treading.SetActive (true);
			Floating.SetActive (true);
			Swimming.SetActive (true);
		}
		if (Time.fixedTime >= 24) {

			T_rb.useGravity = true;
			F_rb.useGravity = true;
			S_rb.useGravity = true;
			L_rb.useGravity = true;
		}
		if (Time.fixedTime >= 25) {//
			C1.SetActive (true);
			C2.SetActive (true);
			C3.SetActive (true);
			C4.SetActive (true);
		}
		if (Time.fixedTime >= 29) {
			C1_rb.useGravity = true;
			C2_rb.useGravity = true;
			C3_rb.useGravity = true;
			C4_rb.useGravity = true;
		}
        if(Time.fixedTime >= 28)
        {
            rP.useGravity = true;
        }
        if(Time.fixedTime >= 30.5)//
        {
            Plane.SetActive(true);
           
            rP.useGravity = false;
            rP.isKinematic = true;
            Renderer rend = Sphere.GetComponent<Renderer>();
            rend.material = field;
            Rain.SetActive(false);

        }
		if (Time.fixedTime >= 33) {
			Laying.SetActive (false);
			Treading.SetActive (false);
			Floating.SetActive (false);
			Swimming.SetActive (false);
            C1.SetActive (false);
            C2.SetActive (false);
            C3.SetActive (false);
            C4.SetActive (false);
        }
        if(Time.fixedTime >= 47)//
        {
            Renderer r = Sphere.GetComponent<Renderer>();
            r.material = history;
        }
        if(Time.fixedTime >= 63)
        {
            Renderer rend = Sphere.GetComponent<Renderer>();
            rend.material = field;
            Canvas.SetActive(true);
        }
        if(Time.fixedTime >= 91)
        {
            Renderer r = Sphere.GetComponent<Renderer>();
            r.material = space;
        }
        if(Time.fixedTime >= 106.5)
        {
            Renderer rend = Sphere.GetComponent<Renderer>();
            rend.material = field;
            Tree.SetActive(true);
            //head.SetActive(true);
        }
        if(Time.fixedTime >= 140) //
        {
            Renderer r = Sphere.GetComponent<Renderer>();
            r.material = grav;
            Renderer rp = Plane.GetComponent<Renderer>();
            rp.material = grav;
            Tree.SetActive(false);
            Canvas.SetActive(false);
            Plane.SetActive(false);
        }
	}

}
