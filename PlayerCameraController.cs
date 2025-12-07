using Godot;
using System;

public partial class PlayerCameraController : Camera3D
{
	public const float MouseSensitivity = 0.002f;

	public override void _UnhandledInput(InputEvent e)
	{
		if (e is InputEventMouseMotion mouseMotion)
		{
			RotateX(-mouseMotion.Relative.Y * MouseSensitivity);
			// Clamp the vertical rotation to avoid flipping the camera.
			RotationDegrees = new Vector3(
				Mathf.Clamp(RotationDegrees.X, -89, 89),
				RotationDegrees.Y,
				RotationDegrees.Z
			);
		}
	}
}
