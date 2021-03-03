using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class SingleReferenceBehaviour : PlayableBehaviour {
	public override void ProcessFrame (
		Playable playable, FrameData info, object playerData) {
		if (playerData == null) return;
		float normTime = (float) (playable.GetTime () / playable.GetDuration ());
		GameObject cubeObject = playerData as GameObject;
		cubeObject.transform.position = new Vector3 (8.0f, 2.0f * normTime, 0.0f);
	}
}