using UnityEngine;

public class ColissionAndColour : MonoBehaviour {
  private Renderer rend;

  void Start() {
    rend = GetComponent<Renderer>();
  }

  void OnCollisionEnter(Collision collision) {
    Debug.Log(gameObject.name + " collisioned with: " + collision.gameObject.name);

    rend.material.color = Random.ColorHSV();
  }
}

