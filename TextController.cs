using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		bedroom, door, bedroom_1, bedroom_2, corridor_0, corridor_1, stairs, free, mirror, cupboard, toilet, toiletSearch
	};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.bedroom;
	}

	// Update is called once per frame
	void Update () {
		print(myState);
		if(myState == States.bedroom){
			bedroom();
		}
		if(myState == States.door){
			door();
		}
		if(myState == States.corridor_0){
			corridor_0();
		}
		if(myState == States.corridor_1){
			corridor_1();
		}
		if(myState == States.toilet){
			toilet();
		}
		if(myState == States.toiletSearch){
			toiletSearch();
		}
		if(myState == States.bedroom_1){
			bedroom_1();
		}
		if(myState == States.mirror){
			mirror();
		}
		if(myState == States.cupboard){
			cupboard();
		}
		if(myState == States.bedroom_2){
			bedroom_2();
		}
		if(myState == States.stairs){
			stairs();
		}
		if(myState == States.free){
			free();
		}
	}

	void bedroom ()
	{
		text.text = "You are currently in one of the bedrooms in this haunted house and you need to escape." + 
		             "There is a door to leave the room but you are not sure what you can find outside,\n\n"  +
		             "Press O to open the door" ;

		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.door;
		}            
	}

	void door ()
	{
		text.text = "You have opened the door now you have to decide which corridor you want to go to \n\n" +
					"Press R to go the right corridor or L to go the left corridor";

		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.corridor_0;
		}

		if(Input.GetKeyDown(KeyCode.L)){
			myState = States.corridor_1;
		}
	}

	void corridor_0 ()
	{
		text.text = "You can go to the toilet on your left if you press L or you can enter the bedroom if you press R and to go back to the door press B";
		if(Input.GetKeyDown(KeyCode.L)){
			myState = States.toilet;
		}

		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.bedroom_1;
		}

		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.door;
		}
	}

	void toilet ()
	{
		text.text = "You are in the toilet now, but the tap is randomly running with blood dripping from the tap" +
					"what will you do now as you are really scared will you leave or stay to search if there is a key\n\n" +
					"Press L to leave and go back or S to stay and search";

		if(Input.GetKeyDown(KeyCode.L)){
			myState = States.corridor_0;
		}

		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.toiletSearch;
		}
	}

	void toiletSearch ()
	{
		text.text = "There is no key here so you can leave and try to search another area\n\n" + 
					"Press to L leave the toilet and go back to the corridor";

		if(Input.GetKeyDown(KeyCode.L)){
			myState = States.corridor_0;
		}
	}

	void bedroom_1 ()
	{
		text.text = "You have entered the parents bedroom their is only a mirror and a cupboard\n\n" +
		            "Press P to pickup the mirror or G to go the cupboard or to L leave the room";

		if(Input.GetKeyDown(KeyCode.P)){
			myState = States.mirror;
		}

		if(Input.GetKeyDown(KeyCode.G)){
			myState = States.cupboard;
		}

		if(Input.GetKeyDown(KeyCode.L)){
			myState = States.corridor_0;
		}
	}

	void mirror ()
	{
		text.text = "You have now picked up the mirror and you are currently looking at it " +
					"but you can only see someone else inside the mirror and now you are really scared\n\n" +
					"Press to D to drop the mirror and leave the room";

		if(Input.GetKeyDown(KeyCode.D)){
			myState = States.corridor_0;
		}
	}


	void cupboard ()
	{
		text.text = "There is a key lying on top of the cupboard\n\n" +
					"Press T to take the key and leave the room";

		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.corridor_0;
		}
	}

	void corridor_1 ()
	{
		text.text = "There is a bedroom on the right and on the left you can walk down the stairs or you can go back to the door\n\n" +
					"Press R to go the bedroom or T to take the stairs or B to go back to the door";

		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.bedroom_2;
		}

		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.stairs;
		}

		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.door;
		}
	}

	void bedroom_2 ()
	{
		text.text = "There is a ghost standing right behind you and now the door is closed and you have been trapped forever" +
		    		"and can never escape.\n\n" +
		    		"Press P to play again" ;

		if(Input.GetKeyDown(KeyCode.P)){
			myState = States.bedroom;
		}
	}

	void stairs ()
	{
		text.text = "There is a door their but you need a key to open the door\n\n" +
					"Press O to open the door if you have the key if you don't press B to go back to find the key";

		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.free;
		}

		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.corridor_1;
		}
	}

	void free ()
	{
		text.text = "You are now free run away !!! \n\n" +
		            "Thank you for playing Press P to play again" +
		            " Press E to quit";

		if(Input.GetKeyDown(KeyCode.P)){
			myState = States.bedroom;
		}

		if(Input.GetKeyDown(KeyCode.E)){
			Application.Quit();
		}
	}
}
