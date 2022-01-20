using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;
using UnityEditor.Tilemaps;
[CustomEditor(typeof(CheckerBrush))]
public class CheckerBrushEditor : GridBrushEditorBase {
    /// <summary>Returns all valid targets that the brush can edit.</summary>
    /// <remarks>Valid targets for the CheckeredBrush are any GameObjects with a Tilemap component.</remarks>
    public override GameObject[] validTargets {
        get {
            var tilemap = GameObject.FindObjectsOfType<Tilemap>();
            return tilemap.Select(x => x.gameObject).ToArray();
        }
    }
}
