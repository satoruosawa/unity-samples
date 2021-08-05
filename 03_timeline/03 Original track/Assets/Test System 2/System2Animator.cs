using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System2Animator : AAnimator
{
  public override void UpdateSequenceValue(float value)
  {
    Debug.Log("call system2 animator" + value);
  }
}
