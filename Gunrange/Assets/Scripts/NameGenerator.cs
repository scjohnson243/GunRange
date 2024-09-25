using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NameGenerator : MonoBehaviour {
    [SerializeField] private NameData _nameData;

    public string GenerateRandomName()
    {
        if (_nameData == null || _nameData.firstName.Count == 0 || _nameData.lastName.Count == 0)
        {
            Debug.LogError("NameData is missing or Empty!");
            return "Unknown";
        }

        string firstName = _nameData.firstName[Random.Range(0, _nameData.firstName.Count)];
        string lastName = _nameData.lastName[Random.Range(0, _nameData.lastName.Count)];

        return $"{firstName} {lastName}";

    }
}
