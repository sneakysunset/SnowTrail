using UnityEngine;
using UnityEngine.Rendering.Universal;

public class UpdateRenderTarget : MonoBehaviour
{
    [SerializeField] Camera _camera;
    [SerializeField] CameraClearFlags _flags;
    private void Start()
    {
        _camera.clearFlags = _flags;
    }
}
