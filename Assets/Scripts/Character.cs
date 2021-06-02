using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Serialization
{

    [System.Serializable]
    public class Character
    {
        public string name;
        public int health;
        public int healthRegen;
        public int healthLevel;
        public int stamina;
        public int staminaRegen;
        public int staminaLevel;
        public int mana;
        public int manaRegen;
        public int manaLevel;
        public int baseSpeed;

        public Character(string _name, int _health, int _healthRegen, int _healthLevel, int _stamina,
            int _staminaRegen, int _staminaLevel, int _mana, int _manaRegen, int _manaLevel, int _baseSpeed)
        {
            name = _name;
            health = _health;
            healthRegen = _healthRegen;
            healthLevel = _healthLevel;
            stamina = _stamina;
            staminaRegen = _staminaRegen;
            staminaLevel = _staminaLevel;
            mana = _mana;
            manaRegen = _manaRegen;
            manaLevel = _manaLevel;
            baseSpeed = _baseSpeed;
        }
    }
}
