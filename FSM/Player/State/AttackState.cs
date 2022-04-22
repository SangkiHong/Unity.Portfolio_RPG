﻿using UnityEngine;

namespace SK.FSM
{
    public class AttackState : StateBase
    {
        private readonly PlayerStateManager _state;
        public AttackState(PlayerStateManager psm) => _state = psm;

        private Vector3 _targetDir;
        private Quaternion _lookRot;

        public override void StateInit()
        {
            _state.anim.SetBool(Strings.animPara_isInteracting, true);
            _state.EnableRootMotion();

            _targetDir = _state.cameraManager.transform.forward;
            _targetDir.y = 0;
            _lookRot = Quaternion.LookRotation(_targetDir);
        }

        public override void FixedTick()
        {
            // Attack 실행되기 전까지 input 받기
            if (!_state.combat.attackExcuted)
                _state.inputManager.Execute();

            _state.mTransform.rotation = Quaternion.Lerp(_state.mTransform.rotation, _lookRot, _state.fixedDelta * _state.rotationSpeed);
        }

        public override void Tick()
        {
            base.Tick();
            _state.monitorInteracting.Execute();
        }
        public override void StateExit() => _state.DisableRootMotion();

    }
}