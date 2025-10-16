using UnityEngine;

public class ThrowObject : MonoBehaviour {
  public float force = 500f; 
  private Rigidbody rigid;

  void Start() {
    rigid = GetComponent<Rigidbody>();
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.X)) {
        rigid.AddForce(Vector3.forward * force);
        Debug.Log(name + " thrown with strength " + force);
    }
  }
}