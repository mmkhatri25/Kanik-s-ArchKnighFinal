using UnityEngine;

public class SplineWalker : MonoBehaviour
{
	public BezierSpline spline;

	public float duration;

	public bool lookForward;

	public SplineWalkerMode mode;

	private float progress;

	private bool goingForward = true;

	private void Update()
	{
		if (goingForward)
		{
			progress += Time.deltaTime / duration;
			if (progress > 1f)
			{
				if (mode == SplineWalkerMode.Once)
				{
					progress = 1f;
				}
				else if (mode == SplineWalkerMode.Loop)
				{
					progress -= 1f;
				}
				else
				{
					progress = 2f - progress;
					goingForward = false;
				}
			}
		}
		else
		{
			progress -= Time.deltaTime / duration;
			if (progress < 0f)
			{
				progress = 0f - progress;
				goingForward = true;
			}
		}
		Vector3 vector = base.transform.parent.InverseTransformPoint(spline.GetPoint(progress));
		base.transform.localPosition = vector;
		if (lookForward)
		{
			base.transform.LookAt(vector + spline.GetDirection(progress));
		}
	}
}
