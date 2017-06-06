using UnityEngine;

[RequireComponent(typeof(Camera))]
//public abstract class Compose : MonoBehaviour
public class Compose : MonoBehaviour
{
    private Material _material;


    public string ShaderName;

    protected Material Material { get { return _material; } }


    protected virtual void Awake()
    {
        Shader shader = Shader.Find(ShaderName);
        _material = new Material(shader);
    }

    protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, _material);
    }

}