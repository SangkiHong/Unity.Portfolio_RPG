﻿using UnityEngine;

namespace SK
{
    public enum ItemType : int
    { 
        Default,
        Food,
        Buff,
        Quest,
        Equipment
    }

    public enum ItemGrade
    { 
        Normal,
        Magic,
        Rare,
        Epic,
        Unique,
        Legendary
    }

    public enum EquipmentType
    {
        Weapon,
        Armor,
        Shield,
        Gloves,
        Helmet,
        Pants,
        Belt,
        Boots,
        Ring
    }

    [System.Serializable]
    public class Item
    {
        public int Id = 0;
        public string ItemName = "New Item";
        public Sprite ItemIcon = null;
        public ItemType ItemType;
        public ItemGrade ItemGrade;
        // 소모 가능한 아이템 여부
        public bool IsConsumable = false;
        // 아이템 중첩 수량 가능 여부
        public bool IsStackable = false;

        // 장비 타입
        public EquipmentType EquipmentType;
        // 장비 데이터 세부 정보
        public Equipments EquipmentData;
        // 아이템 무게
        public float Weight;
        // 아이템 내구도
        public int Durability;

        // 아이템 구매 가격
        public int ItemPrice;

        // 아이템 설명
        public string Description;

        // 아이템 사용 가능 레벨
        public int RequiredLevel;
        // 착용 기본 능력치(공격력/방어력)
        public int BaseAbility;
        // 착용 추가 능력치(치명타/회피력)
        public int SubAbility;

        // 착용 보너스 힘
        public int Bonus_Str;
        // 착용 보너스 민첩
        public int Bonus_Dex;
        // 착용 보너스 지능
        public int Bonus_Int;

        // 아이템 사용 시 회복량
        public int RecoverHPAmount;
        // 아이템 사용 시 버프 지속 시간
        public float Buff_Duration;
        // 아이템 사용 시 힘 상승
        public int Buff_Str;
        // 아이템 사용 시 민첩 상승
        public int Buff_Dex;
        // 아이템 사용 시 지능 상승
        public int Buff_Int;
    }
}
