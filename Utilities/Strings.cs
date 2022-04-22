﻿using UnityEngine;

namespace SK
{
    public class Strings
    {
        #region Animation
        public static readonly int AnimPara_isFight = Animator.StringToHash("isFight");
        public static readonly int animPara_isInteracting = Animator.StringToHash("isInteracting");
        public static readonly int AnimPara_MoveBlend = Animator.StringToHash("MoveBlend");
        public static readonly int AnimPara_Sideways = Animator.StringToHash("Sideways");
        public static readonly int AnimPara_isShield = Animator.StringToHash("isShield");
        public static readonly int AnimPara_isShielding = Animator.StringToHash("isShielding"); 
        public static readonly int AnimPara_isSecondEquip = Animator.StringToHash("isSecondEquip"); 
        public static readonly int AnimPara_Jump = Animator.StringToHash("Jump");
        public static readonly int AnimPara_Land = Animator.StringToHash("Land");
        public static readonly int AnimPara_Damaged = Animator.StringToHash("Damaged");
        public static readonly int AnimPara_Dead = Animator.StringToHash("Dead");
        public static readonly int AnimPara_AnimSpeed = Animator.StringToHash("AnimSpeed");
        public static readonly string AnimName_Attack_Jump = "Attack_Jump";
        public static readonly string AnimName_Roll = "Roll_Forward";
        public static readonly string AnimName_RollBack = "Roll_Backward";
        public static readonly string AnimName_DodgeRight = "Dodge_Right";
        public static readonly string AnimName_DodgeLeft = "Dodge_Left";
        public static readonly string AnimName_Equip_Sword = "Equip_Sword";
        public static readonly string AnimName_Unequip_Sword = "Unequip_Sword";
        public static readonly string AnimName_Equip_Shield = "Equip_Shield";
        public static readonly string AnimName_Unequip_Shield = "Unequip_Shield";
        public static readonly string AnimName_Shielding = "Shielding"; 
        public static readonly string AnimName_Shield_Hit = "Shield_Hit";
        #endregion

        #region Pool
        public static readonly string PoolName_DamagePoint = "DamagePoint";


        #endregion
    }
}