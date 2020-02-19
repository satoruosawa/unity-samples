using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
// A behaviour that is attached to a playable
public class SimplePlayableBehaviour : PlayableBehaviour {
	public GameObject cubeObject;

	// Called when the owning graph starts playing
	public override void OnGraphStart (Playable playable) {
		Debug.Log ("SimplePlayableBehaviour.OnGraphStart");
	}

	// Called when the owning graph stops playing
	public override void OnGraphStop (Playable playable) {
		Debug.Log ("SimplePlayableBehaviour.OnGraphStop");
	}

	// Called when the state of the playable is set to Play
	public override void OnBehaviourPlay (Playable playable, FrameData info) {
		Debug.Log ("SimplePlayableBehaviour.OnBehaviourPlay");
		cubeObject.transform.position = new Vector3 (4.0f, 0.0f, 0.0f);
	}

	// Called when the state of the playable is set to Paused
	public override void OnBehaviourPause (Playable playable, FrameData info) {
		Debug.Log ("SimplePlayableBehaviour.OnBehaviourPause");
		cubeObject.transform.position = new Vector3 (4.0f, 0.0f, 0.0f);
	}

	// Called each frame while the state is set to Play
	public override void PrepareFrame (Playable playable, FrameData info) {
		// Debug.Log ("SimplePlayableBehaviour.PrepareFrame");
	}

	// This function is called during the ProcessFrame phase of the PlayableGraph.
	public override void ProcessFrame (Playable playable, FrameData info, object playerData) {
		// Debug.Log ("SimplePlayableBehaviour.ProcessFrame");
		float normTime = (float) (playable.GetTime () / playable.GetDuration ());
		cubeObject.transform.position = new Vector3 (4.0f, 2.0f * normTime, 0.0f);
	}
}