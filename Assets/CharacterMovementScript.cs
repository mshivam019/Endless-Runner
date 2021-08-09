using System.Collections;
using UnityEngine;
public class CharacterMovementScript : MonoBehaviour {
private Animator animator;
private int lane;
// Use this for initialization
void Start () {
lane = 0;
animator = GetComponent<Animator> ();
}
// Update is called once per frame
void Update () {
if(Input.GetKeyDown(KeyCode.LeftArrow)){
if(lane > -1)
lane--;
}
if(Input.GetKeyDown(KeyCode.RightArrow)){
if(lane < 1)
lane++;
}
Vector3 newPosition = transform.position;
newPosition.x = lane;
transform.position = newPosition;
transform.Rotate(Vector3.up, 0.0f);
}
}
