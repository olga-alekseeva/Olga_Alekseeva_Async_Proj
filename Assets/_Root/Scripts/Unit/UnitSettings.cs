using Abstractions.Unit;
using UnityEngine;

namespace Unit
{
    [CreateAssetMenu(fileName = nameof(UnitSettings), menuName = "ScriptableObject/" + nameof(UnitSettings))]
    public class UnitSettings : ScriptableObject, IUnitSettings
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _health;

        public float Speed => _speed;
        public float Health => _health;
    }

}