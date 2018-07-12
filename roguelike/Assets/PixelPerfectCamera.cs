//This script is based off of https://github.com/cmilr/DeadSimple-Pixel-Perfect-Camera

using UnityEngine;
using UnityEngine.Assertions;

[ExecuteInEditMode]
public class PixelPerfectCamera : MonoBehaviour
{
	public float FinalUnitSize 		{ get { return finalUnitSize; } }
	public int   PixelsPerUnit 		{ get { return pixelsPerUnit; } }
	public int   VertUnitsOnScreen 	{ get { return verticalUnitsOnScreen; } }

	[SerializeField]
	private int pixelsPerUnit = 16;
	[SerializeField]
	private int verticalUnitsOnScreen = 4;
	private float finalUnitSize;
	private new Camera camera;

	void Awake()
	{
		camera = gameObject.GetComponent<Camera>();
		Assert.IsNotNull(camera);

		SetOrthographicSize();
	}

	void SetOrthographicSize()
	{
		ValidateUserInput();

		var tempUnitSize = Screen.height / verticalUnitsOnScreen;
		finalUnitSize = GetNearestMultiple(tempUnitSize, pixelsPerUnit);
		camera.orthographicSize = Screen.height / (finalUnitSize * 2.0f);
	}

	int GetNearestMultiple(int value, int multiple)
	{
		int rem = value % multiple;
		int result = value - rem;
		if (rem > (multiple / 2))
			result += multiple;

		return result;
	}

	void ValidateUserInput()
	{
		if (pixelsPerUnit == 0)
		{
			pixelsPerUnit = 1;
			Debug.Log("Warning: Pixels-per-unit must be greater than zero. " +
			          "Resetting to minimum allowed."); 
		}
		else if (verticalUnitsOnScreen == 0)
		{
			verticalUnitsOnScreen = 1;
			Debug.Log("Warning: Units-on-screen must be greater than zero." +
			          "Resetting to minimum allowed.");
		}
	}
}
