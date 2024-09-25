using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewNameData", menuName = "Customer/NameData")]
public class NameData : ScriptableObject {
    public List<string> firstName;
    public List<string> lastName;
}
